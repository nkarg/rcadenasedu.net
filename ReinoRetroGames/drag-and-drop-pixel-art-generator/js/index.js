var dropImage; // global, set when image changes

$(function() {
  // suppress assets pop-up for codepen pro accounts
  $('html').on('dragenter dragover', function(e) {
    e.stopPropagation();
  });
  
  // image changed
  $('.drop-image').on('load', function() {
    if (this.naturalWidth > 64 || this.naturalHeight > 64) {
      showDropError('IMAGE TOO LARGE');
    } else {
      dropImage = this;
      calculatePixels();
      renderDrop();
      renderMarkup();
    }
  });
  
  // drag and drop stuff
  $('.drop-zone')
    .on('dragover', function() {
      $(this).addClass('drop-over');
      return false;
    })
    .on('dragleave', function() {
      $(this).removeClass('drop-over');
      return false;
    })
    .on('drop', function(e) {
      $(this).removeClass('drop-over');
      loadFromDesktop(e.originalEvent.dataTransfer.files[0]);
      e.preventDefault();
      return false;
    });
  
  // sample images
  $('.drop-samples img').on('click', function() {
    loadFromSamples(this.src);
  });
  
  $('.drop-image, .drop-samples img').on('dragstart', function(e) {
    // this is a band-aid to prevent confusion
    e.preventDefault();
  });

  // scale slider
  $('.scale-slider').on('change', function() {
    updateScale(this.value);
  });
});

function loadFromDesktop(file) {
  if (!file || file.type.indexOf('image/') !== 0) {
    showDropError('NOT AN IMAGE');
  } else {
    var reader = new FileReader();
    reader.onload = function(e) {
      $('.drop-image').attr('src', e.target.result);
    };
    reader.readAsDataURL(file);
  }
}

function showDropError(message) {
  $('body').removeClass('loaded');
  $('.drop-image').hide();
  $('.drop-placeholder')
    .text(message)
    .addClass('error')
    .show();
}

function loadFromSamples(src) {
  $('.drop-image').attr('src', src);
}

function updateScale(scale) {
  $('.scale h2').html('&times; ' + scale);
  renderMarkup();
}

function calculatePixels() {
  // create context
  var canvas = document.createElement('canvas');
  canvas.width = dropImage.naturalWidth;
  canvas.height = dropImage.naturalHeight;
  var context = canvas.getContext('2d');
  
  // draw green screen
  context.beginPath();
  context.rect(0, 0, dropImage.naturalWidth, dropImage.naturalHeight);
  context.fillStyle = 'rgb(1, 255, 1)';
  context.fill();
  
  // get image data
  context.drawImage(dropImage, 0, 0);
  var data = context.getImageData(0, 0, dropImage.naturalWidth, dropImage.naturalHeight).data;
  
  // translate image data to pixel objects
  var pixels = [];
  for (var i = 0; i < dropImage.naturalWidth * dropImage.naturalHeight; i++) {
    var r = data[i * 4];
    var g = data[i * 4 + 1];
    var b = data[i * 4 + 2];
    
    if(r !== 1 || g !== 255 || b !== 1) {
      pixels.push({
        x: i % dropImage.naturalWidth,
        y: Math.floor(i / dropImage.naturalWidth),
        hex: rgbToHex(r, g, b)
      });
    }
  }
  
  // save work
  dropImage.pixels = pixels;
}

function renderDrop() {
  // show drop image centered
  $(dropImage)
    .show()
    .css('margin', (dropImage.naturalHeight / -2) + 'px 0 0 ' + (dropImage.naturalWidth / -2) + 'px');

  // update UI
  $('.drop-placeholder').hide();
  $('.drop h2').html(dropImage.naturalWidth + 'px &times; ' + dropImage.naturalHeight + 'px');
  $('body').addClass('loaded');
}

function renderMarkup() {
  var scale = parseInt($('.scale-slider').val(), 10);
  var marginLeft = (dropImage.naturalWidth - 1) * scale;
  var marginBottom = (dropImage.naturalHeight - 1) * scale;

  var bgColor;
  var shadows = [];
  for (var i = 0; i < dropImage.pixels.length; i++) {
    var pixel = dropImage.pixels[i];
    
    if (i === 0 && pixel.x === 0 && pixel.y === 0) {
      // topmost leftmost pixel becomes background color
      bgColor = pixel.hex;
    }
    else {
      // add a box shadow
      var x = pixel.x * scale;
      if (x !== 0) {
        x += 'px';
      }
      var y = pixel.y * scale;
      if (y !== 0) {
        y += 'px';
      }
      shadows.push(x + ' ' + y + ' ' + pixel.hex);
    }
  }
  
  // create style string
  var style =
    'display: inline-block;\n' +
    'width: ' + scale + 'px;\n' +
    'height: ' + scale + 'px;\n' +
    'margin: 0 ' + marginLeft + 'px ' + marginBottom + 'px 0;\n' +
    (bgColor ? 'background-color: ' + bgColor + ';\n' : '') +
    'box-shadow:\n  ' + shadows.join(',\n  ') + ';';
  
  // update preview stuff
  $('.preview-anchor').attr('style', style);
  $('.preview h2').html((dropImage.naturalWidth * scale) + 'px &times; ' + (dropImage.naturalHeight * scale) + 'px');

  // update css stuff
  $('.css-output').val(style);
  $('.css h2').html(style.match(/\n/g).length + ' lines');
}

function rgbToHex(r, g, b) {
  var hex = ((1 << 24) + (r << 16) + (g << 8) + b)
    .toString(16)
    .slice(1);
  
  // short format
  if (hex[0] === hex[1] && hex[2] === hex[3] && hex[4] === hex[5]) {
    hex = hex[0] + hex[2] + hex[3];
  }
  
  return '#' + hex;
}