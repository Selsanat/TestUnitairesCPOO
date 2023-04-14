﻿using _2023_GC_A2_Partiel_POO.Level_2;

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2023_GC_A2_Partiel_POO.Tests.Level_2
{
    public class FightMoreTests
    {
        // Tu as probablement remarqué qu'il y a encore beaucoup de code qui n'a pas été testé ...
        // À présent c'est à toi de créer les TU sur le reste et de les implémenter
        
        // Ce que tu peux ajouter:
        // - Ajouter davantage de sécurité sur les tests apportés
            // - un heal ne régénère pas plus que les HP Max
            // - si on abaisse les HPMax les HP courant doivent suivre si c'est au dessus de la nouvelle valeur
            // - ajouter un equipement qui rend les attaques prioritaires puis l'enlever et voir que l'attaque n'est plus prioritaire etc)
        // - Le support des status (sleep et burn) qui font des effets à la fin du tour et/ou empeche le pkmn d'agir
        // - Gérer la notion de force/faiblesse avec les différentes attaques à disposition (skills.cs)
        // - Cumuler les force/faiblesses en ajoutant un type pour l'équipement qui rendrait plus sensible/résistant à un type

        [Test]

        public void TheHealDoesntHealMoreThanTheMaxHP()
        {
            var c = new Character(100, 50, 30, 20, TYPE.NORMAL);
            var heal = new WishHeal();
            var p = new Punch();
            Character pikachu = new Character(100, 50, 30, 20, TYPE.NORMAL);
            Character bulbizarre = new Character(100, 60, 10, 200, TYPE.NORMAL);
            Fight f = new Fight(pikachu, bulbizarre);

            // Both uses heal
            f.ExecuteTurn(heal, heal);
            Assert.That(pikachu.CurrentHealth, Is.EqualTo(pikachu.MaxHealth));
            f.ExecuteTurn(p, p);
            Assert.That(pikachu.CurrentHealth, Is.EqualTo(60));
            f.ExecuteTurn(heal, heal);
            Assert.That(pikachu.CurrentHealth, Is.EqualTo(100));
        }

        [Test]

        public void IfWeReduceMaxHpWeAlsoReduceCurrentHp()
        {
            var c = new Character(100, 50, 30, 20, TYPE.NORMAL);

            Assert.That(c.CurrentHealth, Is.LessThanOrEqualTo(c.MaxHealth));
        }

        [Test]

        public void isStillPriotaryOrNot()
        {
            var c = new Character(100, 50, 30, 20, TYPE.NORMAL);

            
        }

    }
}
