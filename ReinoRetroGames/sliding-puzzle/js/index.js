var start_btn = $("#start"),
    curtime=[0,0,0];

//divide board into piece_number pieces
function initPuzzle(){
  var board = $("#board"),
    img = $("#board-image"),
    src = "http://img3.douban.com/lpic/s3054604.jpg",
    board_w = img.width(),
    board_h = img.height(),
    x_number = 3,
    y_number = 3,
    piece_w = Math.floor( board_w/x_number),
    piece_h = Math.floor( board_h/y_number),
    piece_number = x_number*y_number,
    pos = getRandArray(piece_number); //store positions of all pieces
   
  //create new board
  for(var i=0; i<x_number; i++){//line
    for(var j=0; j<y_number; j++){//column
      
      //set background of each piece
      if(i===0 && j===0){
        continue;
      }
      
      var idx = i*x_number + j,
          x = Math.floor(pos[idx]/x_number),
          y = pos[idx] - x*x_number;
      var pcs = document.createElement("div");
      pcs.idx = idx;
      board.append(
        $(pcs)
          .addClass("piece")
          .css({
            "width": piece_w+"px",
            "height": piece_h+"px",
            "top": x*piece_h+"px",
            "left": y*piece_w+"px"
          })
          .click(movePiece)//when a piece is clicked, check if it is adjacent to piece 0
          .append($("<img />")
            .attr("src", src)
            .css({
              "height": board_h,
              "width": board_w,
              "margin-left": -j*piece_w+"px",
              "margin-top": -i*piece_h+"px"
            })
          )
      );
    }
  }
 
  //hide init image
  img.hide();

  //generate an array that records pieces' positions
  function getRandArray(num){
    var arr = new Array(num),
        MAX_ITR = num*10;
    for(var i=0; i<num; i++){
      arr[i] = i;
    }
    //randonmize arr by exchanging randomly selected indices
    for(i=0; i<MAX_ITR; i++){
      var idx1 = Math.floor(Math.random() * (num-1)) + 1,
          idx2 = Math.floor(Math.random() * (num-1)) + 1,
          tmp = arr[idx1];
      arr[idx1] = arr[idx2];
      arr[idx2] = tmp;    
    }
    return arr;
  }

  function movePiece(){
    //if is adjacent to blank piece
    var piece = $(this),
        pPos = pos[this.idx],
        zPos = pos[0];
    console.log("piece pos:"+pPos+", blanket pos:"+zPos);
    
    if(!isAdj(pPos, zPos)){
      console.log("this piece is not movable.");
      return; // the piece is not movable
    }
    var x = Math.floor(zPos / y_number),
        y = zPos - x*y_number;
    
    //move the piece to blanket position
    console.log("move to("+x*piece_h+","+y*piece_w+")");
    piece.css({
      "top": x*piece_h+"px",
      "left": y*piece_w+"px"
    });
    //update pos array
    pos[this.idx] = zPos,
    pos[0] = pPos;

    //check if the game finishes
    if(checkResult()){
      finish();
    }
  }

  //if two pieces are adjacent 
  function isAdj(pos1, pos2){  
    //pos1, pos2 are numbers 0~8
    return (Math.abs(pos1 - pos2) === 1 && //pos1,2 are in the same row  
     Math.floor(pos1/y_number) === Math.floor(pos2/y_number))||(
      Math.abs(pos1 - pos2) === 3);//same column
  }

  function checkResult(){// the position array
    for(var i=1; i<pos.length; i++){
      if(pos[i]!==i)
        return false;
    }
    return true;
  }

  function finish(){
    start_btn.show();
    start_btn.text("Replay");
    alert("Congratulations! You've finished in "+$("#current-time").text());
    curtime = [0, 0, 0];
  }
}

//start calculting time when press start button
start_btn.click(function(){
  //set timer
  setTimeout(timer, 1000);
  //divide img into piece_number pieces
  initPuzzle();
  $(this).hide();
});

function timer(){
  for(var i=2; i>=0; i--){
     if((curtime[i]<59 && i>0) || (i===0 &&curtime[i]<23)){
          curtime[i]++;
          break;
     }else{curtime[i]=0;}
  }
  var displayTime = curtime.map(function(x){return x<10? "0"+x:x;}).join(":");
  $("#current-time").text(displayTime);
  setTimeout(timer, 1000);
}