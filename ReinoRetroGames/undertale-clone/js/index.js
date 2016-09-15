/* clear the codepen console */
console.clear();

var currentContext = 'action';
var actionIndex = 1;
var menuIndex = 1;
var maxIndex = 4;
var dialog = '';
var actionSelector = $('.action-option');
var heartSpeed = 30;

/* audio vars */
var menuMove = new Audio('move.mp3');
var menuSelect = new Audio('select.mp3');

/* enemies */
var enemies = {
  "Temmie":{
    "sprite":"http://res.cloudinary.com/daniel-griffiths/image/upload/v1473626874/temmie_nss3il.gif",
    "music":"https://www.youtube.com/embed/JRU6GnETSN4?autoplay=1&version=3&loop=1&autoplay=1&rel=0&showinfo=0&autohide=1&playlist=JRU6GnETSN4&vq=tiny",
    "dialog":"Special enemy Temmi appears here to defeat you!!",
    "gold":"150",
    "act-options":["Check","Flex","Feed Flakes","Talk"]
  },  
  "Sans":{
    "sprite":"http://res.cloudinary.com/daniel-griffiths/image/upload/v1473626872/sans_kckyu7.gif",
    "music":"https://www.youtube.com/embed/B2jVbSI9H4o?autoplay=1&version=3&loop=1&autoplay=1&rel=0&showinfo=0&autohide=1&playlist=B2jVbSI9H4o&vq=tiny",
    "dialog":"You’re Gonna Have a Bad Time",
    "gold":"150",
    "act-options":["Check"]
  },  
  "Papyrus":{
    "sprite":"http://res.cloudinary.com/daniel-griffiths/image/upload/v1473626873/papyrus_fk7omx.png",
    "music":"https://www.youtube.com/embed/mqzBv3FYpr0?autoplay=1&version=3&loop=1&autoplay=1&rel=0&showinfo=0&autohide=1&playlist=mqzBv3FYpr0&vq=tiny",
    "dialog":"Papyrus blocks the way!",
    "gold":"150",
    "act-options":["Check","Flirt","Insult"]
  },  
  "Undyne":{
    "sprite":"http://res.cloudinary.com/daniel-griffiths/image/upload/v1473626870/undyne_sy9laq.gif",
    "music":"https://www.youtube.com/embed/YTy9v9a7Tmo?autoplay=1&version=3&loop=1&autoplay=1&rel=0&showinfo=0&autohide=1&playlist=YTy9v9a7Tmo&vq=tiny",
    "dialog":"Undyne prepares for battle!",
    "gold":"150",
    "act-options":["Check","Talk"]
  }, 
  "Asgore":{
    "sprite":"http://res.cloudinary.com/daniel-griffiths/image/upload/v1473626876/asgore_rfa9nv.gif",
    "music":"https://www.youtube.com/embed/pcamjcoRmrQ?autoplay=1&version=3&loop=1&autoplay=1&rel=0&showinfo=0&autohide=1&playlist=pcamjcoRmrQ&vq=tiny",
    "dialog":"(A strange light fills the room. )",
    "gold":"150",
    "act-options":["Check","Talk"]
  },  
  "Muffet":{
    "sprite":"http://res.cloudinary.com/daniel-griffiths/image/upload/v1473626876/muffet_mgre2y.gif",
    "music":"https://www.youtube.com/embed/qgFkG80INO0?autoplay=1&version=3&loop=1&autoplay=1&rel=0&showinfo=0&autohide=1&playlist=qgFkG80INO0&vq=tiny",
    "dialog":"The spiders clap to the music.",
    "gold":"0",
    "act-options":["Check","Struggle","Pay 40g"]
  }, 
}

/* 
|---------------------------------------
| On load
|--------------------------------------- 
*/

$(function(){
 

  function rand(obj) {
      var result;
      var count = 0;
      for (var prop in obj)
          if (Math.random() < 1/++count)
             result = prop;
      return result;
  }
  
  /* load random enemy */
  function loadEnemy(enemies){
    
    var randomEnemy = rand(enemies);
    var sprite = enemies[randomEnemy]['sprite'];
    var music = enemies[randomEnemy]['music'];
    gold = enemies[randomEnemy]['gold'];
    
    dialog = enemies[randomEnemy]['dialog'];
    
    /* Asgore is special ;) */
    if(randomEnemy == 'Asgore'){
      $('.action-option:last-child').fadeOut();
      maxIndex = 3;
    }
    
    /* populate the act menu */
   $.each(enemies[randomEnemy]['act-options'],function(key,value){
      $('.menu-act').append('<li class="menu-option">* '+ value +'</li>');
   });
    
    
    $('.undertale').addClass(randomEnemy);
    $('.enemy img').attr('src',sprite);
    $('.audio').attr('src',music);
    
  }
  
  loadEnemy(enemies);
  
  /* text animation */
  $('.menu-dialog').typed({
      strings: [dialog],
      showCursor: false,
      cursorChar: '',
      typeSpeed: 20,
      loop: false,
      loopCount: false,
  });  
  
  /* scaling code from http://stackoverflow.com/questions/18750769/scale-div-with-its-content-to-fit-window */
  /*
  var maxWidth  = $('body').width();
  var maxHeight = $('body').height();

  $(window).resize(function(evt) {
    var $window = $(window);
    var width = $window.width();
    var height = $window.height();
    var scale;

    scale = Math.min(width/maxWidth, height/maxHeight);

    $('.undertale').css({'-webkit-transform': 'scale(' + scale + ')'});
    $('body').css({ width: maxWidth * scale, height: maxHeight * scale });
  });
  */


/* 
|---------------------------------------
| Action Menu Functions
|--------------------------------------- 
|
| Used the navigate the bottom menu bar
|
*/
  
  /* move left */
  function prevAction(actionMenuItem){
    if(actionIndex > 1 && currentContext == 'action'){
      actionIndex--;
      actionSelector.removeClass('active');
      $('.action-option-' + actionIndex).addClass('active');
      console.log(actionIndex);
    }
  }

  /* move right */
  function nextAction(actionMenuItem){
    if(actionIndex < maxIndex && currentContext == 'action'){
      actionIndex++;
      actionSelector.removeClass('active');
      $('.action-option-' + actionIndex).addClass('active');
      console.log(actionIndex);
    }
  }
  
  /* move heart during battle */
  function heartMove(direction,offset){
    $('.battle-heart').stop().animate({
      [direction]: offset + '=' + heartSpeed
    }); 
  }
  
  /* show restart screen */
  function showRestartDialog(){
      $('.restart').fadeIn('slow');
    
      $('.restart').click(function(){
        //document.location.reload(); //codepen doesnt like this?
      });
  }

/* 
|---------------------------------------
| Confirm Button
|--------------------------------------- 
*/

  Mousetrap.bind('enter', function(){ 

    /* set the new content and show the relevant menu */
    if(currentContext == 'action'){
      currentContext = $('.action-option-' + actionIndex).data('context');
      $('.menu-' + currentContext).show(); 
      $('.action-option-' + actionIndex).removeClass('active');
      console.log(currentContext);
    }

    /* FIGHT */
    if(currentContext == 'fight'){
        
        /* random test code */
        /*
        $(document).keypress(function(e) {
            if(e.which == 13) { 
                alert('this shouldnt happen right away! :(');
            }
        });
        */

        /* animate the attack line */
        $('.attack-line').animate({
          left: "97%"
        }, 1000, function() {
        
        /* reset attack line position */
        $('.attack-line').removeAttr("style");
        
        /* Its now the enemies turn! */
        $('.menu-fight').hide();
        $('.menu-fight-enemy-turn').fadeIn('1').addClass('menu-tall');
          
        currentContext = 'fight-enemy-turn';
        
        /* reset heart position */
        $('.battle-heart').removeAttr("style");
        
        /* just a placeholder, hide the battle screen after 3 seconds */
        setTimeout(function(){
          $('.menu-fight-enemy-turn').fadeOut('1').removeClass('menu-tall');
          $('.action-option-' + actionIndex).addClass('active');  
          currentContext = 'action';
        }, 3000);
      });
    }

    /* ACT */
    if(currentContext == 'act'){

    }

    /* ITEM */    
    if(currentContext == 'item'){

    }

    /* MERCY */
    if(currentContext == 'mercy'){
      $('.enemy').css('opacity','0.3');
      $('.audio').remove();
      $('.menu-mercy').css('color','white');
      
      /* play sound effect */
      var audio = new Audio('http://danielgriffiths.me/project-files/undertale/spare.mp3');
      audio.play();
      
      /* show spare dialog  */ 
      var spareDialog = '* YOU WON! <br>* You earned 0 XP and ' + gold + ' gold.';
      
      $('.menu-mercy').typed({
          strings: [spareDialog], 
          showCursor: false, 
          cursorChar: '', 
          typeSpeed: 20,
          loop: false,
          loopCount: false,
      });  
      
      /* force img to stay on the first frame (very hacky) */
      setInterval(function() {
        $('.enemy img').attr('src',$('.enemy img').attr('src'))
      },1)

      currentContext = 'battle-finished';
       
      showRestartDialog();

    } 
  });

/* 
|---------------------------------------
| Cancel Button
|--------------------------------------- 
*/

  Mousetrap.bind('esc', function() {
    /* get out of the sub menus */
    if(currentContext == 'act'
       || currentContext == 'item'
       || currentContext == 'mercy'){
      $('.menu-' + currentContext).hide();
      $('.action-option-' + actionIndex).addClass('active');
      currentContext = 'action';
    } 
  });


/* 
|---------------------------------------
| Arrow Keys
|--------------------------------------- 
*/
  
  /* up key */
  Mousetrap.bind('up', function() {     
    if(currentContext == 'fight-enemy-turn'){
      heartMove('top','-');
    }
  });
  
  /* down key */
  Mousetrap.bind('down', function() {   
    if(currentContext == 'fight-enemy-turn'){
      heartMove('top','+');
    }
  });
  
  /* right key */
  Mousetrap.bind('right', function() { 
    if(currentContext == 'action'){
      nextAction($(this));
    }
    
    if(currentContext == 'fight-enemy-turn'){
      heartMove('left','+');
    }
  });
  
  /* left key */
  Mousetrap.bind('left', function() { 
    if(currentContext == 'action'){
      prevAction($(this));
    }
    
    if(currentContext == 'fight-enemy-turn'){
      heartMove('left','-');
    }
  });
  

/* end document ready */
});