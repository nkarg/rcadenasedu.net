	
/*
 * Function puzzle
 * Hector Barragan Estebaranz
 * class puzzle
 * 14-01-2014
 * */

function puzzle()
{
	this.rows;
	this.cols;
	this.rute;
	
	/*variables constructor*/
	this.pref="img_";
	this.ext=".jpg";
	this.width=150;
	this.height=150;
	this.bol="false";
	
	this.construct = function (rows,cols,rute)
	{
		this.setRows(rows);
		this.setCols(cols);
		this.setRute(rute);
	}
	
	this.getRows = function (){return this.rows;}
	this.getCols = function (){return this.cols;}
	this.getRute = function (){return this.rute;}
	
	this.setRows = function (rows){this.rows = rows;}
	this.setCols = function (cols){this.cols = cols;}
	this.setRute = function (rute){this.rute = rute;}
	
/*
 * Function random
 * Hector Barragan Estebaranz
 * Function to return array random
 * return Array 
 * parameters none;
 * */

	this.random = function ()
	{
		//position random 
		var pos1=0;
		var pos2=0;
		var contadorImg=0;
		var check=false;
		//init array
		var arrayRandom = new Array(this.cols*this.rows);
	
			//add value to compare 000 to fill the array
			for (var i = 0; i < this.cols; i++)
			{
				arrayRandom[i]=new Array(this.rows);
				for (j = 0; j < this.rows; j++)
				{
					arrayRandom[i][j]=000;
				}
				
			}
			//add random pictures in the array
			for (i = 0; i < this.rows; i++)
			{
				
				for (j = 0; j < this.cols; j++)
				{
				check = true;//bol to vail
					do{
						pos1= Math.floor((Math.random()*this.cols));//position random
						pos2= Math.floor((Math.random()*this.cols));//position random
						if(arrayRandom[pos1][pos2]==000)
						{
						//if position array is empty add image img_(i)	
						arrayRandom[pos1][pos2]="<img id='"+i+j+"' src='"+this.rute+this.pref+0+contadorImg+this.ext+"' width='"+this.width+"' height='"+this.height+"' >";
						check=false//change boolean to exit bucle
						}
				  }while(check!=false)
				  contadorImg++;
				 }
				  
				  
			}

		pos1= Math.floor((Math.random()*this.cols));//position random
		pos2= Math.floor((Math.random()*this.cols));//position random
		arrayRandom[pos1][pos2]="<img id='img99' src='"+this.rute+this.pref+99+this.ext+"' width='"+this.width+"' height='"+this.height+"' >";
		return arrayRandom;
	}
	


/*
 * Function checkResult
 * Hector Barragan Estebaranz
 * Check correct position puzzle if return 1, the puzzle is correctly
 * Function to return bol 
 * class puzzle
 * 14-01-2014
 * */

this.checkResult = function()
{
		
		var bol = 0;
		for (i = 0; i < Globalcols; i++)
		{
			for (j = 0; j < Globalrow; j++)
			{
				var idTd = document.getElementById("pos"+i+""+j).id;//id td
				var idImg = document.getElementById("pos"+i+""+j).getElementsByTagName("img")[0].id;//id img
				var idTdPosition = idTd.substring(3,5);//delete "pos" for compare
		
				if(idTdPosition!=idImg){
					bol++;
					}
			}
		}
		return bol;
		
}
	
/*
 * Function changePosition
 * Hector Barragan Estebaranz
 * Change position piece
 * class puzzle
 * 14-01-2014
 * */

this.changePosition = function(position,row,cols)
{
				var posTd = document.getElementById("pos"+row+""+cols);	
				var ImgOnClick = position.innerHTML;
				var ImgRigth = posTd.innerHTML;
				position.innerHTML=ImgRigth;
				posTd.innerHTML=ImgOnClick;		
}

/*
 * Function chargeTable()
 * Hector Barragan Estebaranz
 * Function that returns a content string containing the table print
 * return String content;
 * parameters row,cols,ArrayRandom;
 * 14-01-2014
 * */

this.chargeTable = function(row,cols,ArrayRandom){
	var aux=0;
	var content="<div id='box1'><table>";
	for (i = 0; i < row ; i++)
	{
	    content += "<tr>";
		for (j = 0; j < cols; j++)
		{
			content += "<td id='pos"+i+j+"' onclick='movePosition("+i+","+j+")'>"+ArrayRandom[i][j]+"</td>";//pasar dos valores  
			aux++;
		}
		content += "</tr>";
		
	}
	content += "</table></div><div id='box2'><br /><img id='imgAll' src='img/img_all.jpg' width='200px' /> <p>Number of changes</p><input type='text' id='changes' value='0' /><input type='button' id='reload'  value='Reload page' onclick='load()'  /> </div>";
	
	return content;
}

/*
 * Function executeTask()
 * Hector Barragan Estebaranz
 * Function collect img99(img blank), check errors(click img99 or img out range),
 * return none;
 * parameters:row,cols,positionId,position;
 * 14-01-2014
 * */
this.executeTask = function(row,cols,positionId,position){
	
	var contador = document.getElementById("changes").value;//input save changes
	var positionTomove;
	var newCol,newRow;
	var a = new puzzle();
	
	if(positionId=="img99")//check error click img99
	{
	  alert("This is the piece that can move, can move horizontal, vertical and diagonal.");
		}else{
			/*Get the position of the image around*/
			/*obtain img rigth*/
			var whitePieceFound =false;
			
			if(cols+1<Globalcols){//if not out range cols+1
		
				positionTomove = document.getElementById("pos"+row+""+(cols+1)).getElementsByTagName("img")[0].id;
				if(positionTomove=="img99"){
					whitePieceFound =true;
					newCol=cols+1;
					newRow=row;
				}
			}
			
			/*obtain img left*/
			if(cols-1>=0 && !whitePieceFound){ //if not out range cols-1
			
				positionTomove = document.getElementById("pos"+row+""+(cols-1)).getElementsByTagName("img")[0].id;
				if(positionTomove=="img99"){
					whitePieceFound =true;
					newCol=cols-1;
					newRow=row;
				}
			}
			
			//obtain img bot
			if(row-1>=0 && !whitePieceFound){//if out range

				positionTomove = document.getElementById("pos"+(row-1)+""+cols).getElementsByTagName("img")[0].id;
				if(positionTomove=="img99"){
					whitePieceFound =true;
					newCol=cols;
					newRow=row-1;
				}
			}
			
			
			//obtain img top
			if(row+1<Globalcols && !whitePieceFound){//if out range
				positionTomove = document.getElementById("pos"+(row+1)+""+cols).getElementsByTagName("img")[0].id;
				if(positionTomove=="img99"){
					whitePieceFound =true;
					newCol=cols;
					newRow=row+1;
				}
			}
			
	
			//obtain img top-left
			if(row+1<Globalcols && cols+1<Globalcols && !whitePieceFound){//if out range
				positionTomove = document.getElementById("pos"+(row+1)+""+(cols+1)).getElementsByTagName("img")[0].id;
				if(positionTomove=="img99"){
					whitePieceFound =true;
					newCol=cols+1;
					newRow=row+1;
				}
			}
			
			//obtain img bot-rigth
			if(row-1>=0  && cols-1>=0 && !whitePieceFound){//if out range
				positionTomove = document.getElementById("pos"+(row-1)+""+(cols-1)).getElementsByTagName("img")[0].id;
				if(positionTomove=="img99"){
					var whitePieceFound =true;
					newCol=cols-1;
					newRow=row-1;
				}
			}
			
			//obtain img bot-left
			if(row+1<Globalcols && cols-1>=0 && !whitePieceFound){//if out range
				positionTomove = document.getElementById("pos"+(row+1)+""+(cols-1)).getElementsByTagName("img")[0].id;
				if(positionTomove=="img99"){
					var whitePieceFound =true;
					newCol=cols-1;
					newRow=row+1;
				}
			}
			
			//obtain img top-rigth
			if(row-1>=0 && cols+1<Globalcols && !whitePieceFound){
				positionTomove = document.getElementById("pos"+(row-1)+""+(cols+1)).getElementsByTagName("img")[0].id;
				if(positionTomove=="img99"){
					var whitePieceFound =true;
					newCol=cols+1;
					newRow=row-1;
				}
			}
			
			
			/*move or error msg*/	
				if(whitePieceFound==false){
					alert("Invalid move.");
				}else if(positionTomove=="img99"){
					a.changePosition(position,newRow,newCol);
					contador++;
				}
			//change valor input
			document.getElementById("changes").value=contador;
			
			}//FIN ELSE 
			if(a.checkResult()==1){
				alert("Good game.You've completed the game in "+contador+" turns.");
				document.getElementById("reload").style.display = 'block';
				}
	
	}
}
