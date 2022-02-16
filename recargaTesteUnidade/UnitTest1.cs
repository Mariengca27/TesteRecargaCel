using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;



    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Owner("MarianaM")]
        [Description("Conta positiva o que permite a recarga")]
        [Priority(1)]
        public void recargaCelularOk()
        {
            double depMoney = 20.0;

            bool resultado = Class1.RecargaIsOk(depMoney);

            Assert.IsTrue(resultado); 

        }

        [TestMethod]
        [Owner("MarianaM")]
        [Description("Conta negativa o que não permite a recarga.")]
        public void recargaCelularNaoOK()
        {

            double depMoney = -30.0;
            bool resultado = Class1.RecargaIsOk(depMoney);
            Assert.IsTrue(resultado);
        }


        [TestMethod]
        [Owner("MarianaM")]
        [Description("Conta zerada o que não permite a recarga.")]
        public void recargaCelularZero()
        {

            double depMoney = 0.0;
            bool resultado = Class1.RecargaIsOk(depMoney);
            Assert.IsTrue(resultado);

        }

    }


