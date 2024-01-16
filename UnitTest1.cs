using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace extremniprogramovanirpr2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*test na vypis hlasky postavy*/
            string hlaska = Hlaska();
            Assert.IsTrue(hlaska);
        }

        [TestMethod]
        public void TestMethod2()
        {
            /*test na zivotnost bosse*/
            int bossHP = HPboss();
            Assert.IsTrue(bossHP > 0);
        }

        [TestMethod]
        public void TestMethod3()
        {
            /*test na delku jmena*/
            string jmeno = "JohnDoe";
            int maxDelka = 10;


            Assert.IsTrue(jmeno.Length > maxDelka);
        }

        [TestMethod]
        public void TestMethod4()
        {
            /*test na zivotnost osoby*/
            int hp = HPosoba();
            Assert.IsTrue(hp > 0);
        }

        [TestMethod]
        public void TestMethod5()
        {
            /*test na defense*/
            int def = Defosoba();
            Assert.IsTrue(def > 0);
        }

        [TestMethod]
        public void TestMethod6()
        {
            /*test na dmg osoby*/
            int damage = OsobaDMG();
            Assert.IsTrue(damage > 0);
        }

        [TestMethod]
        public void TestMethod7()
        {
            /*test na dmg Boss*/
            int damageBoss = BossDMG();
            Assert.IsTrue(damageBoss > 0);
        }

        [TestMethod]
        public void TestMethod8()
        {
            /*test na XP*/
            int xp = XP();
            
            Assert.IsTrue(xp > 0);
        }

        [TestMethod]
        public void TestMethod9()
        {
            /* Test na porovnání života postavy a bosse */
            int zivotPostavy = VratHPosoba();
            int zivotBosse = VratHPboss();
            Assert.IsTrue(zivotPostavy > zivotBosse);
        }

        [TestMethod]
        public void TestMethod10()
        {
            /* Test na útok bosse na postavu */
            int obranaOsoby = VratDefOsoby();
            int utokBosse = BossDMG();
            Assert.IsTrue(utokBosse > obranaOsoby);
        }

        [TestMethod]
        public void TestMethod11()
        {
            /* Test na zkušenosti a level postavy */
            int xp = XP();
            int level = lvl();

            Assert.IsTrue(xp >= 0 && level >= 1);
        }

    }
}
