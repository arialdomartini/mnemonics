Liskov Substitution Principle
============================

Esercizio basato sul brillante articolo [Visualization Mnemonics for Software Principles](http://www.daedtech.com/visualization-mnemonics-for-software-principles) di [Erik Dietrich](https://twitter.com/daedtech)

A me piace sempre accompagnare la cena con una buona insalata. Avete presente, una con dentro le solite cose: lattuga, pomodori, crostini, cipolline, carote e cicuta. In ogni modo, una delle cose che faccio diversamente dagli altri, è il modo in cui ispeziono meticolosamente ogni singolo ingrediente della mia insalata, prima di metterlo in bocca, per capire se mi ucciderà o no (molte persone che amano l'insalata sembrano voler richiare la loro vita, e consumano l'insalata molto velocemente. Mah!). Io mi affido ad un algoritmo molto semplice: se l'ingrediente non è cicuta, la mangio. Se è cicuta, la metto da parte per poi buttarlo. Raccomando caldamente a tutti di consumare così una buona insalata di cicuta.


In alternativa, potreste prendere in considerazione il Principio di Sostituzione di Liskov, che sostanzialmente dice che quando esiste una relazione di ereditarietà tra degli elementi, i tipi derivati dovrebbero essere sostituibili trasparentemenre con gli elementi del proprio tipo genitore. Per esempio, se si ha una insalata di tipi `Commestibili`, non dovrebbe esistere un tipo `Cicuta` che non si comporti come gli altri tipi `Commestibili`. Un'altro modo di vedere la questione è questa: se si ha una collezione eterogenea di elementi appartenenti ad una determinata gerarchia legata da eredità, non dovrebbe essere necessario sfogliarne uno ad uno per domandarmi "*vediamo questo elemento di che tipo è per capire se vada trattato in modo speciale". Per cui, aderisci al Principio di Sostituzione di Liskov e non preparare insalate di cicuta alla gente. Otterrai del codice più pulito, ed eviterai la galera.


# La sfida

Il fattto che `Hemlock` non sia sostituibile con gli altri ingredienti di tipo `IEdible` è abbastanza evidente nel metodo `Eat(Salad salad)`:

```csharp
    public string Eat(Salad salad)
    {
        var myself = this;
        var comments = new List<string>();

        foreach(var ingredient in salad.Ingredients)
        {
            if(ingredient.GetType() != typeof(Hemlock))
                comments.Add(ingredient.Feed(myself));
        }

        return string.Join("\n", comments);
    }

```

Vedi l'`if`? Riesci ad eliminarlo, aderendo al Principio di Sostituzione di Liskov?

Un buon riferimento per risolvere questo problema è la risposta che [dasblinkenlight](http://programmers.stackexchange.com/users/44705/dasblinkenlight) dà alla domanda su Programmers Stackexchange [Is this a violation of the Liskov Substitution Principle?](https://programmers.stackexchange.com/questions/170138/is-this-a-violation-of-the-liskov-substitution-principle/170142#170142)
