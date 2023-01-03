﻿using FastMechanical.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FastMechanical.Models {
    public class Estoque {

        public int Id { get; set; }
        public Materiais Material { get; set; }
        public int Baixa { get; set; }
        public int Adicao { get; set; }
        public string Observacao { get; set; }
        public Pessoa Executor { get; set; }
        public int AtendimentoId { get; set; }
        public string NumeroNotaFiscal { get; set; }
        public string ChaveAcessoNotaFiscal { get; set; }
        public DateTime? DataBaixa { get; set; }
        public DateTime? DataAdicao { get; set; }

        public TipoMovimentacao TipoMovimentacao { get; set; }
        public Estoque() {
        }

        public Estoque(Materiais material, int baixa, int adicao, string observacao, Pessoa executor, int atendimentoId) {
            Material = material;
            Baixa = baixa;
            Adicao = adicao;
            Observacao = observacao;
            Executor = executor;
            AtendimentoId = atendimentoId;
        }
    }
}
