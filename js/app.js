'use strict';

function main() {
    var objCliente = {
        cpf: "",
        nome: "",
        sobrenome: "",
        rua: "",
        numero: 0,
        telefone: ""
    };

    var arrayVetor = ["a", "b", "c", "d"];
    var arrayMatriz = [
        [1, 2, 3],
        [4, 5, 6],
        [7, 8, 9]
    ];

    var arrayMatriz = [
        ["Fausto", "Ava1", "pt-br"],
        ["José", "Ava2", "en"],
        ["Sarah", "Ava3", "pt"],
    ];

    for (let lin = 0; lin < 3; lin++) {
        for (let col = 0; col < 3; col++)
            console.log(arrayMatriz[lin][col] + "  ");
        console.log("---");
    }

    for (var i = 0; i < 5; i++) {
        arrayVetor[i] = arrayVetor[i] + "$";
    }

    console.log(arrayVetor);

    var i = 0;
    while (i < 5) {
        arrayVetor[i] = arrayVetor[i].charAt(0);
        i++;
    }

    console.log(arrayVetor);
    console.log(objCliente);    
    console.log("Resposta da questão de prova: " + prova());

}

//Questão de prova

function prova(){
    var arrayMatriz = [
        ["Fausto", "Ava1", "pt-br"],
        ["José", "Ava2", "en"],
        ["Sarah", "Ava3", "pt"],
    ];
    
    console.log(arrayMatriz.length);

    for (let lin = 0; lin < 3; lin++) {
        for (let col = 0; col < 3; col++)

            //A instrução 'arrayMatriz.length' retorna um inteiro que representa o tamanho do array
            if(lin == (arrayMatriz.length - 1)){
                return arrayMatriz[lin][0];
            }
    }

    return null;
}

main();

