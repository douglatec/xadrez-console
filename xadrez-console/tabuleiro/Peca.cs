﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimento { get; protected set; }
        public Tabuleiro tab { get; protected set; }


        public Peca(Tabuleiro tab, Cor cor) 
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;  
            this.qteMovimento = 0;
                  
        }
    }
}
