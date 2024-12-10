using DolgozatProject;

namespace TestDolgozatProject
{
    public class Tests
    {
        Dolgozat d;

        [SetUp]
        public void Setup()
        {
            d = new Dolgozat();
        }

        [Test]
        public void PontotFelvesz_ErvenyesAdattal_NemDobExceptiont()
        {
            Assert.DoesNotThrow(() => d.PontFelvesz(50));
        }

        [Test]
        public void PontotFelvesz_ErvenytelenAdattal_DobExceptiont()
        {
            Assert.Throws<ArgumentException>(() => d.PontFelvesz(101));
        }

        [Test]
        public void PontotFelvesz_ErvenytelenAdattal_DobExceptiont2()
        {
            Assert.Throws<ArgumentException>(() => d.PontFelvesz(-2));
        }

        [Test]
        public void MindenkiMegirta_NemIrtakDolgozatot()
        {
            d.PontFelvesz(-1);
            Assert.IsFalse(d.MindenkiMegirta());
        }

        [Test]
        public void MindenkiMegirta_IrtakDolgozatot()
        {
            d.PontFelvesz(50);
            Assert.IsTrue(d.MindenkiMegirta());
        }

        [Test]
        public void Bukas_NemIrtakDolgozatot()
        {
            d.PontFelvesz(-1);
            Assert.AreEqual(0, d.Bukas);
        }

        [Test]
        public void Bukas_IrtakDolgozatot()
        {
            d.PontFelvesz(20);
            Assert.AreEqual(1, d.Bukas);
        }

        [Test]
        public void Elegseges_NemIrtakDolgozatot()
        {
            d.PontFelvesz(-1);
            Assert.AreEqual(0, d.Elegseges);
        }

        [Test]
        public void Elegseges_IrtakDolgozatot_EsNincs()
        {
            d.PontFelvesz(50);
            Assert.AreEqual(1, d.Elegseges);
        }

        [Test]
        public void Elegseges_IrtakDolgozatot_EsVan()
        {
            d.PontFelvesz(55);
            Assert.AreEqual(1, d.Elegseges);
        }

        [Test]
        public void Kozepes_NemIrtakDolgozatot()
        {
            d.PontFelvesz(-1);
            Assert.AreEqual(0, d.Kozepes);
        }

        [Test]
        public void Kozepes_NemIrtakDolgozatot_EsNincs()
        {
            d.PontFelvesz(50);
            Assert.AreEqual(0, d.Kozepes);
        }

        [Test]
        public void Kozepes_NemIrtakDolgozatot_EsVan()
        {
            d.PontFelvesz(65);
            Assert.AreEqual(1, d.Kozepes);
        }

        [Test]
        public void Jo_NemIrtakDolgozatot()
        {
            d.PontFelvesz(-1);
            Assert.AreEqual(0, d.Jo);
        }

        [Test]
        public void Jo_IrtakDolgozatot_EsNincs()
        {
            d.PontFelvesz(50);
            Assert.AreEqual(0, d.Jo);
        }

        [Test]
        public void Jo_IrtakDolgozatot_EsVan()
        {
            d.PontFelvesz(75);
            Assert.AreEqual(1, d.Jo);
        }

        [Test]
        public void Jeles_NemIrtakDolgozatot()
        {
            d.PontFelvesz(-1);
            Assert.AreEqual(0, d.Jeles);
        }

        [Test]
        public void Jeles_NemIrtakDolgozatot_EsNincs()
        {
            d.PontFelvesz(80);
            Assert.AreEqual(0, d.Jeles);
        }

        [Test]
        public void Jeles_NemIrtakDolgozatot_EsVan()
        {
            d.PontFelvesz(85);
            Assert.AreEqual(1, d.Jeles);
        }

        [Test]
        public void Gyanus_ErvenytelenAdattal_DobExceptiont()
        {
            Assert.Throws<ArgumentException>(() => d.Gyanus(-1));
        }

        [Test]
        public void Gyanus_ErvenyesAdattal_NemDobExceptiont()
        {
            d.PontFelvesz(85);
            Assert.DoesNotThrow(() => d.Gyanus(0));
        }

        [Test]
        public void Gyanus_ErvenyesAdattal_FalsetAdVissza()
        {
            d.PontFelvesz(85);
            d.PontFelvesz(85);
            d.PontFelvesz(85);
            Assert.IsFalse(d.Gyanus(3));
        }

        [Test]
        public void Gyanus_ErvenyesAdattal_TruetAdVissza()
        {
            d.PontFelvesz(85);
            Assert.IsTrue(d.Gyanus(0));
        }

        [Test]
        public void Ervenytelen_TruetAdVissza()
        {
            d.PontFelvesz(-1);
            d.PontFelvesz(-1);
            d.PontFelvesz(-1);
            d.PontFelvesz(85);
            d.PontFelvesz(85);
            Assert.IsTrue(d.Ervenytelen);
        }

        [Test]
        public void Ervenytelen_FalsetAdVissza()
        {
            d.PontFelvesz(-1);
            d.PontFelvesz(-1);
            d.PontFelvesz(85);
            d.PontFelvesz(85);
            d.PontFelvesz(85);
            Assert.IsFalse(d.Ervenytelen);
        }

        [Test]
        public void Ervenytelen_UresLista()
        {
            Assert.IsTrue(d.Ervenytelen);
        }
    }
}