
/*
  Classe autogenerata dal tool RecClassCreator
  by Stefano teodorani il 09/08/2013 14.35.39
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace AMHelper.CSV
{
    /// <summary>
    /// Tracciato record delle unit� di misura articolo.
    /// Contiene la lista di tutte le unit� di misura possibili per ogni singolo Codice Articolo (COD_ART).
    /// </summary>
    public class rec_art_um
    {
        // CHIAVE|COD_DITTA|COD_ART|UM|DESC_UM|FAT_CONV|TIPO_UM|FLG_DEFAULT|DAT_ULT_MOD

        /// <summary>
        /// Chiave univoca della riga
        /// </summary>
        public string CHIAVE { get; set; }    
        /// <summary>
        /// Codice della ditta. 
        /// Identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, pu� contenere dati di pi� aziende
        /// </summary>
        public string COD_DITTA { get; set; }  
        /// <summary>
        /// Codice dell'articolo
        /// </summary>
        public string COD_ART { get; set; }
        // Codice dell'unit� di misura (Es: PZ=Pezzi, KG=Chilogrammi, ecc...)
        public string UM { get; set; }
        /// <summary>
        /// Descrizione dell'unit� di misura (Es: Pezzi, Chilogrammi, ecc...)
        /// </summary>
        public string DESC_UM { get; set; }
        /// <summary>
        /// Fattore di conversione. 
        /// Coefficiente da applicare alle unit� di misura per ricondursi all'unit� di misura principale (quella di tipo 1).
        /// Per le unit� di misura di tipo 1 non serve e va impostato a 0 (zero).
        /// </summary>
        public string FAT_CONV { get; set; }
        /// <summary>
        /// Tipo Unit� di misura.
        /// Valori possibili:
        ///   1 = Unit� di misura principale (Pu� esserci solo una riga con FAT_CONV=0)
        ///   2 = Unit� di misura secondarie (Possono esserci pi� righe)
        ///   3 = Confezioni. Viene trattato come UM di tipo 2 ma con possibilit� di impostare controlli (es. Rottura confezioni)
        /// </summary>
        public string TIPO_UM { get; set; }
        /// <summary>
        /// Flag che identifica l'unit� di misura di default, ovvero quella che deve essere proposta quando si inserisce un nuovo ordine.
        /// In molti gestionali � chiamata unit� di misura di Vendita. 
        /// Valori consentiti: 0 = Normale (default), -1 = Predefinita
        /// </summary>
        public string FLG_DEFAULT { get; set; }
        /// <summary>
        /// Data di ultima modifica del record
        /// </summary>
        public string DAT_ULT_MOD { get; set; }

    }
}