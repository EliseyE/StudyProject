﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyInterfacesInheritance
{
    interface IHasInfo
    {
        void ShowInfo();
    }

    interface IWeapon
    {
        int Damage { get; }
        void Fire();
    }

    abstract class Weapon : IHasInfo, IWeapon
    {
        public abstract int Damage { get; }
        public abstract void Fire();

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} Damage: {Damage}");
        }
    }

    class Gun : Weapon
    {
        public override int Damage { get { return 15; } }

        public override void Fire()
        {
            Console.WriteLine("Bang!");
        }
    }

    class LaserGun : Weapon
    {
        public override int Damage { get { return 25; } }

        public override void Fire()
        {
            Console.WriteLine("Piuu!");
        }
    }

    class RocketLauncher : Weapon
    {
        public override int Damage => 85;

        public override void Fire()
        {
            Console.WriteLine("Boom!");
        }
    }

    class Player
    {
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }

        public void ChckInfo(IHasInfo hasInfo)
        {
            hasInfo.ShowInfo();
        }
    }

    class Box : IHasInfo
    {
        public void ShowInfo()
        {
            Console.WriteLine("I'm the box");
        }
    }

    internal class ProgramIntefaceExample
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Weapon[] inventory = { new Gun(), new LaserGun(), new RocketLauncher() };

            foreach (var item in inventory)
            {
                player.ChckInfo(item);
                player.Fire(item);
                Console.WriteLine();
            }

            player.ChckInfo(new Box());

            Console.ReadKey();
        }
    }
}
