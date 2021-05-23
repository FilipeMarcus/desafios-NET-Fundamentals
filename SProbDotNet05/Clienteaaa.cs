using System;

namespace SProbDotNet05
{
    public class Cliente
    {
        private bool Mexeu {get; set;}
        private int Senha {get; set;}
        private int Chegada {get; set;}
        private int LugarAtual {get; set;}

        public Cliente(int chegou, int lugar, int sorte, bool mexido)
        {
            this.Chegada = chegou;
            this.LugarAtual = lugar;
            this.Senha = sorte;
            this.Mexeu = mexido;
        }
        public int getSenha(){
            return this.Senha;
        }
        public int getChegada(){
            return this.Chegada;
        }
        public int getLugarAtual(){
            return this.LugarAtual;
        }
        public bool getMexeu(){
            return this.Mexeu;
        }
        public void PassarNaFrente(Cliente perdeu)
        {
            int tempSpot = this.LugarAtual;
            this.LugarAtual = perdeu.LugarAtual;
            perdeu.LugarAtual = tempSpot;
            this.Mexeu = true;
            perdeu.Mexeu = true;

        }
        public override string ToString()
		{
            string retorno = "";
            retorno += "Senha: " + this.Senha + " | ";
            retorno += "Chegou: " + this.Chegada + " | ";
            retorno += "Mexeu: " + this.Mexeu + " | ";
            retorno += "LugarAtual: " + this.LugarAtual;
			return retorno;
		}
    }
}/*public static int OrganizarFila(List<Cliente> mess, int nCli)
        {
            int retorno = nCli;
            //Console.WriteLine(nCli);
            for(int i=0; i < mess.Count; i++)
            {
                Cliente prox = new Cliente(mess[i].getChegada(), mess[i].getLugarAtual(),
                                            mess[i].getSenha(), mess[i].getMexeu());

                if (filaOrdenada.Count == 0 || prox.getSenha() <= mess[i-1].getSenha())
                {
                    filaOrdenada.Add(prox);
                    //Console.Write("if 1\n");
                }
                else if (prox.getSenha() > mess[i-1].getSenha())
                {
                    //Console.Write("if 2\n");
                    prox.PassarNaFrente(mess[i-1]);
                    filaOrdenada.RemoveAt(i-1);
                    filaOrdenada.Add(prox);
                    filaOrdenada.Add(mess[i-1]);
                }
            }
            foreach(Cliente cli in filaOrdenada)
            {
                //Console.WriteLine(cli.ToString());
                if (cli.getMexeu())
                {
                    retorno -= 1;
                }
            }
            filaChegada.Clear();
            filaOrdenada.Clear();
            return retorno;
        }*/

       /* public class Cliente
        {
            private bool Mexeu {get; set;}
            private int Senha {get; set;}
            private int Chegada {get; set;}
            private int LugarAtual {get; set;}

            public Cliente(int chegou, int lugar, int sorte, bool mexido)
            {
                this.Chegada = chegou;
                this.LugarAtual = lugar;
                this.Senha = sorte;
                this.Mexeu = mexido;
            }
            public int getSenha(){
                return this.Senha;
            }
            public int getChegada(){
                return this.Chegada;
            }
            public int getLugarAtual(){
                return this.LugarAtual;
            }
            public bool getMexeu(){
                return this.Mexeu;
            }
            public void PassarNaFrente(Cliente perdeu)
            {
                int tempSpot = this.LugarAtual;
                this.LugarAtual = perdeu.LugarAtual;
                perdeu.LugarAtual = tempSpot;
                this.Mexeu = true;
                perdeu.Mexeu = true;

            }
            public override string ToString()
            {
                string retorno = "";
                retorno += "Senha: " + this.Senha + " | ";
                retorno += "Chegou: " + this.Chegada + " | ";
                retorno += "Mexeu: " + this.Mexeu + " | ";
                retorno += "LugarAtual: " + this.LugarAtual;
                return retorno;
            }*/