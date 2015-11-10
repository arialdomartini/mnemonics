La Legge di Demeter
===================

Esercizio basato sul brillante articolo [Visualization Mnemonics for Software Principles](http://www.daedtech.com/visualization-mnemonics-for-software-principles) di [Erik Dietrich](https://twitter.com/daedtech)

L'altra settimana ero in viaggio, e mi sono fermato ad un Autogrill per farmi una Redbull per stare sveglio durante la guida. Ho preso la lattina dal frigorifero, l'ho poggiata sul tappeto scorrevole della cassa e il commesso mi ha detto "*Fanno 1 euro e 95*". A questo punto, ovviamente, mi sono sfilato i pantaloni. Il tipo alla cassa ha iniziato ad urlare e a parlare di polizia e di atti osceni in luogo pubblico.

Ero confuso, e gli ho detto "*Calma, sto stolo cercando di pagarti: ti passerò i pantaloni, e tu potrai frugare nelle mie tasche, finché troverai il portafogli, dal quale preleverai le banconote che ti servono. Se mi devi del resto, lo potrai mettere nel portafogli, a meno che non si tratti di un resto in monete, nel qual caso potrai mettere le monete direttamente in una delle tasche. Poi potrai restituirmi i pantaloni*".

Il tipo ha tirato fuori una pistola da dietro il banco e mi ha risposto che, in quel negozio, la gente rispetta la Legge di Demeter.

Quindi, cosa sostiene questa legge di Demeter? Beh, sostanzialmente dice "*Dai ai tuoi collaboraatori esattamente quello di cui hanno bisgno, ed evita di dar loro qualcos'altro nel quale siano costretti a frugare solo per trovare quello di cui hanno bisogno*".

Ci sono dei buoni motivi per cui non diamo ai commessi i nostri pantaloni, e nemmeno i nostri portafogli, e per cui invece diamo loro direttamente i soldi: non conviene a nessuno che siano loro a dover frugare nella nostra roba per trovare i soldi. La Legge di Demeter ci incoraggia a pensare nello stesso modo anche quando disegnamo il codice. Evita di restituire un oggetto `Pants`, costringendo chi ti ha chiamato a cercare dentro `Pants.Pocket[1].Wallet.Money` solo per recuperare un'istanza di `Money`: piuttosto, restituisci direttamente `Money`. E, se sei il commesso, non accettare in ingresso `Pants` se hai bisogno di `Money`: pretendi `Money`, oppure preparati a mostrare la pistola.

# Esercizio

Riesci a prendere il codice e modificarlo in modo che rispetti la Legge di Demeter?
