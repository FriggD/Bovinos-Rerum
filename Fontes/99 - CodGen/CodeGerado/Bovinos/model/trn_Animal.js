{
  "name": "Animal",
  "base": "RPOTransaction",
  "tableName": "",
  "transactionName": "",
  "javaimport": [],
  "callBaseWithFalse": true,
  "javapkg": "Bovinos",
  "cspkg": "Bovinos",
  "csimport": [],
  "author": "gmdias",
  "created": "2021-01-07T10:18:38-03:00",
  "modified": "2021-01-07T10:29:20-03:00",
  "attributes": [],
  "associations": [],
  "aggregations": [],
  "transitions": [
    {
      "from": "Inicial",
      "to": "AnimalEditado",
      "event": "EditarAnimal"
    },
    {
      "from": "Inicial",
      "to": "AnimalCadastrado",
      "event": "CadastrarAnimal"
    },
    {
      "from": "Inicial",
      "to": "AnimalConsultado",
      "event": "ConsultarAnimal"
    },
    {
      "from": "Inicial",
      "to": "AnimalListaConsultada",
      "event": "ListarAnimais"
    },
    {
      "from": "Inicial",
      "to": "AnimalRemovido",
      "event": "RemoverAnimal"
    }
  ],
  "events": [
    {
      "name": "EditarAnimal"
    },
    {
      "name": "CadastrarAnimal"
    },
    {
      "name": "ConsultarAnimal"
    },
    {
      "name": "ListarAnimais"
    },
    {
      "name": "RemoverAnimal"
    }
  ],
  "states": [
    {
      "name": "Inicial"
    },
    {
      "name": "AnimalEditado"
    },
    {
      "name": "AnimalCadastrado"
    },
    {
      "name": "AnimalConsultado"
    },
    {
      "name": "AnimalListaConsultada"
    },
    {
      "name": "AnimalRemovido"
    }
  ],
  "estereotipo": "transaction"
}