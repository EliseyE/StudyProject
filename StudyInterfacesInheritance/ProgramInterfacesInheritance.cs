using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyInterfacesInheritance
{
    interface IWeapon
    {
        void Fire();
    }

    class LaserGun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Piuu!");
        }
    }

    class RocketLauncher : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Boom!");
        }
    }

    interface IThowingWeapon : IWeapon
    {
        void Throw();
    }

    class Knife : IThowingWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Hshhh!");
        }

        public void Throw()
        {
            Console.WriteLine($"{GetType().Name}: Vshiiiu!");
        }
    }


    class Player
    {
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }
        public void Throw(IThowingWeapon thowingWeapon)
        {
            thowingWeapon.Throw();
        }
    }

    internal class ProgramIntefaceExample
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            IWeapon[] inventory = { new LaserGun(), new RocketLauncher(), new Knife() };

            foreach (var item in inventory)
            {
                player.Fire(item);
                Console.WriteLine();
            }

            player.Throw(new Knife());

            Console.ReadKey();
        }
    }
}

