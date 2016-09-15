var pika = {
  hp : 200,
  at : 30,
  ha : 2,
  ci : 0.2,
  win : 'http://fc05.deviantart.net/fs50/f/2009/264/f/2/Custom_Pikachu_Sprite_by_Neslug.gif'
}

var chmr = {
  hp : 210,
  at : 31,
  ha : 2,
  ci : 0.2,
  win: 'http://img3.wikia.nocookie.net/__cb20140226225412/mipequeoponyfanlabor/es/images/e/e9/Charmander_sprite.png'
}
var dmg = -chmr.at/pika.ha;
pika.hp += dmg;
setTimeout(function(){
$('.status span').html('Picachu  used <b>BOLT</b>, <i>Super effective</i>, Charmander: '+dmg+'hp');
},3000);
setTimeout(function(){ $('.pika').find('img').attr('src',pika.win);
  $('.status span').html('Charmander fainted, <b>Pikachu Wins !!!</b>');   
                      $('.chmr').find('img').css('opacity',0);},6000)