		
//global variables
var Globalrow = 3;
var Globalcols = 3;
var rute = 'img/';

/*
 * Function onload()
 * Hector Barragan Estebaranz
 * Function to onload body idex.htmml
 * Return none;
 * Parameters none;
 * 14-01-2014
 * */

function onload(){

	var NewGame = new puzzle();
	NewGame.construct(Globalrow,Globalcols,rute);
	var ArrayRandom = NewGame.random();//generate random array
	var content = NewGame.chargeTable(Globalrow,Globalcols,ArrayRandom);//return string table
	document.getElementById("content").innerHTML= content;//print
	document.getElementById('changes').disabled="disabled";//disabled input

}

/*
 * Function movePosition
 * Hector Barragan Estebaranz
 * Collected positionId and position and call executeTask(row,cols,positionId,position)
 * Return: none
 * Parameters: row,cols
 * 14-01-2014
 * */	

function movePosition(row,cols){

	var positionId = document.getElementById("pos"+row+""+cols).getElementsByTagName("img")[0].id;
	var position = document.getElementById("pos"+row+""+cols);//td clicked	
	var NewGame = new puzzle();
	NewGame.executeTask(row,cols,positionId,position);

	}

function load() 
{

	setTimeout("location.reload(true);",1);

}

	
