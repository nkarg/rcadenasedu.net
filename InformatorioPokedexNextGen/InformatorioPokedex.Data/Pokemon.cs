using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data
{
    public class Pokemon: IBug, IDark, IDragon, IElectric, IFairy, IFighting, IFire, IFlying, IGhost, IGrass, IGround, IIce, INormal, IPoison, IPsychical, IRock, ISteel, IWater
    {
        public string nombre { get; set; }
        public string tipo { get; set; }
        public string alias { get; set; }
        public float peso { get; set; }
        public float altura { get; set; }

        public Pokemon(string var_nombre,string var_tipo, string var_alias, float var_peso, float var_altura)
        {
            nombre = var_nombre;
            tipo = var_tipo;
            alias = var_alias;
            peso = var_peso;
            altura = var_altura;
        }

        public string placaje()
        {
            return "pokemon ha usado PLACAJE!! ha restado 15 ps al enemigo";
           
        }

        public string gruñido()
        {
            return "pokemon ha usado GRUÑIDO!! resistencia del enemigo ha bajado";
        }

        public string descripcion(string name)
        {
            if (name == "Charmander")
            {
                return "La llama que tiene en la punta de la cola arde según sus sentimientos.\nLlamea levemente cuando está alegre y arde vigorosamente cuando está enfadado.";
            }
            else if(name == "Squirtle")
            {
                return "El caparazón de Squirtle no le sirve de protección únicamente. \nSu forma redondeada y las hendiduras que tiene le ayudan a deslizarse en el agua y le permiten nadar a gran velocidad.";
            }
            else
            {
                return "A Bulbasaur es fácil verle echándose una siesta al sol. \nLa semilla que tiene en el lomo va creciendo cada vez más a medida que absorbe los rayos del sol.";
            }
        }

        public void megahorn()
        {
            Console.WriteLine("Using its tough and impressive horn, the user rams into the target with no letup.");
        }

        public void hyperspaceFury()
        {
            Console.WriteLine("Hyperspace Fury deals damage but lowers the user's Defense by one stage after attacking. The move always hits, even if the target used a Protect-like move.");
        }

        public void roarOfTime()
        {
            Console.WriteLine("The user blasts the target with power that distorts even time. The user can’t move on the next turn.");
        }

        public void boltStrike()
        {
            Console.WriteLine("The user surrounds itself with a great amount of electricity and charges its target. This may also leave the target with paralysis.");
        }

        public void lightOfRuin()
        {
            Console.WriteLine("Light of Ruin deals damage, but the user receives 1⁄2 of the damage it inflicted in recoil. In other words, if the attack does 100 HP damage to the opponent, the user will lose 50 HP.");
        }

        public void focusPunch()
        {
            Console.WriteLine("The user focuses its mind before launching a punch. This move fails if the user is hit before it is used.");
        }

        public void hydroCannon()
        {
            Console.WriteLine("The target is hit with a watery blast. The user can’t move on the next turn.");
        }

        public void doomDesire()
        {
            Console.WriteLine("Two turns after this move is used, the user blasts the target with a concentrated bundle of light.");
        }

        public void vCreate()
        {
            Console.WriteLine("With a hot flame on its forehead, the user hurls itself at its target. It lowers the user’s Defense, Sp. Def, and Speed stats.");
        }

        public void skyAttack()
        {
            Console.WriteLine("A second-turn attack move where critical hits land more easily. This may also make the target flinch.");
        }

        public void shadowForce()
        {
            Console.WriteLine("The user disappears, then strikes the target on the next turn. This move hits even if the target protects itself.");
        }

        public void frenzyPlant()
        {
            Console.WriteLine("The user slams the target with an enormous tree. The user can’t move on the next turn.");
        }

        public void precipiceBlades()
        {
            Console.WriteLine("Precipice Blades deals damage and hits all adjacent opponents in double/triple battles.");
        }

        public void freezeShock()
        {
            Console.WriteLine("On the second turn, the user hits the target with electrically charged ice. This may also leave the target with paralysis.");
        }

        public void explosion()
        {
            Console.WriteLine("The user attacks everything around it by causing a tremendous explosion. The user faints upon using this move.");
        }

        public void gunkShot()
        {
            Console.WriteLine("The user shoots filthy garbage at the target to attack. This may also poison the target.");
        }

        public void psychoBoost()
        {
            Console.WriteLine("The user attacks the target at full power. The attack’s recoil harshly lowers the user’s Sp. Atk stat.");
        }

        public void headSmash()
        {
            Console.WriteLine("The user attacks the target with a hazardous, full-power headbutt. This also damages the user terribly.");
        }
    }
}
