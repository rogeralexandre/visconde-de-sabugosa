// Seção JSON Array do livro NODE.JS Succinctly.
var now = new Date();
var productTransaction = {
                          id : 2,
                          user : 'agusk',
                          transactionDate : now,
                          details : [
                          {
                                code: 'p01',
                                name: 'ipad3',
                                price: 600
                          },
                          {
                                code: 'p02',
                                name: 'galaxy tab',
                                price: 500
                          },
                          {
                                code: 'p03',
                                name: 'kindle',
                                price: 120
                          }]
}

console.log('Exibindo o objeto JSON');
console.log(productTransaction);

// obtendo por atributos.
console.log('---------');
console.log('Exibindo o objeto JSON por atributo.');
console.log('id:' + productTransaction.id);
console.log('user:' + productTransaction.user);
console.log('Transaction date:' + productTransaction.transactionDate);
console.log('Details:' + productTransaction.details);

// obtendo os detalhes do details (que é um array dentro do JSON)
console.log('---------');
console.log('Exibindo o ARRAY Details que está dentro do objeto JSON productTransaction.');
for (var i=0; i < productTransaction.details.length; i++)
{
      console.log('Code:' + productTransaction.details[i].code);
      console.log('Name:' + productTransaction.details[i].name);
      console.log('Price:' + productTransaction.details[i].price);
}

// editando um valor do array dentro do JSON
console.log('---------');
console.log('Alterando o preço do item 0 para 1400:');
productTransaction.details[0].price = 1400;
console.log('Exibindo o ARRAY Details que está dentro do objeto JSON productTransaction.');
for (var i=0; i < productTransaction.details.length; i++)
{
      console.log('Code:' + productTransaction.details[i].code);
      console.log('Name:' + productTransaction.details[i].name);
      console.log('Price:' + productTransaction.details[i].price);
}

// Verificando se o atributo existe ou não.
console.log('---------');
console.log('Verificando se os atributos existem.');
console.log('o id do productTransaction existe?');
console.log(productTransaction['id'] == undefined?false:true);
console.log('o nome do productTransaction existe?');
console.log(productTransaction['name'] == undefined?false:true);
console.log('o código do productTransaction details (linha 0) existe?');
console.log(productTransaction.details[0]['code'] == undefined?false:true);


