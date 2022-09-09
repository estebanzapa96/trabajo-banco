// nombramos una clase 
 class Cliente
    {
        public string nombre;
        public int monto;

//constuctor
        public Cliente(string nom)
        {
            nombre = nom;
            monto = 0;
        }

//set
        public void Depositar(int m)
        {
         this.monto =this.monto + m;
        }

        public void Extraer(int m)
        {
        this.monto =this.monto - m;
        }
//get
        public int RetornarMonto()
        {
            return monto;
        }

        public void Imprimir()
        {
            Console.WriteLine(nombre + " tiene depositado la suma de " + monto);
        }
    }