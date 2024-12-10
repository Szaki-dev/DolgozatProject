namespace DolgozatProject
{
    public class Dolgozat
    {
        private List<int> pontok;
        public Dolgozat() {
            pontok = new List<int>();
        }

        public void PontFelvesz(int x)
        {
            if (x < -1 || x > 100)
            {
                throw new ArgumentException("Érvénytelen paraméter!",nameof(x));
            }
            pontok.Add(x);
        }

        public bool MindenkiMegirta()
        {
            foreach (var item in pontok)
            {
                if (item == -1)
                {
                    return false;
                }
            }
            return true;
        }

        public int Bukas
        {
            get
            {
                int db = 0;
                foreach (var item in pontok)
                {
                    if (item < 50 && item != -1)
                    {
                        db++;
                    }
                }
                return db;
            }
        }

        public int Elegseges
        {
            get
            {
                int db = 0;
                foreach (var item in pontok)
                {
                    if (item >= 50 && item <= 60)
                    {
                        db++;
                    }
                }
                return db;
            }
        }

        public int Kozepes
        {
            get
            {
                int db = 0;
                foreach (var item in pontok)
                {
                    if (item >= 61 && item <= 70)
                    {
                        db++;
                    }
                }
                return db;
            }
        }

        public int Jo
        {
            get
            {
                int db = 0;
                foreach (var item in pontok)
                {
                    if (item >= 71 && item <= 80)
                    {
                        db++;
                    }
                }
                return db;
            }
        }

        public int Jeles
        {
            get
            {
                int db = 0;
                foreach (var item in pontok)
                {
                    if (item > 80)
                    {
                        db++;
                    }
                }
                return db;
            }
        }

        public bool Gyanus(int kivalok)
        {
            if (kivalok < 0)
            {
                throw new ArgumentException("Érvénytelen paraméter!", nameof(kivalok));
            }
            int db = 0;
            foreach (var item in pontok)
            {
                if (item > 80)
                {
                    db++;
                }
            }
            if (db > kivalok)
            {
                return true;
            }
            return false;
        }

        public bool Ervenytelen
        {
            get
            {
                int db = 0;
                foreach (var item in pontok)
                {
                    if (item == -1)
                    {
                        db++;
                    }
                }
                if (db * 2 >= pontok.Count)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
