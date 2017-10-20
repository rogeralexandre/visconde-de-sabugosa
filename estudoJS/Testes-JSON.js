// Roger
// Exemplo tirado do livro (kindle) NODE.JS Succinctly.

// Criando um objeto JSON
var customer = {
                name: 'Michael Z',
                email: 'michael@email.com',
                age: 35,
                registeredDate: new Date(),
                address: {
                            city: 'Berlin',
                            country: 'Germany'
                }
}

// Visualizando este objeto
console.log(customer);

// Visualizando atributos específicos
console.log('Name:' + customer.name);
console.log('email:' + customer.email);
console.log('age:' + customer.age);
console.log('Registered Date:' + customer.registeredDate);

// tentando visualizar um atributo que não existe
console.log('Country:' + customer.country);
// o undefined apareceu depois que eu adicionei este comentário, será que falta um ENTER?

console.log('Address.city: ' + customer.address.city);
console.log('Address.country: ' + customer.address.country);

// iterando pelo objeto
console.log('Passando pelos atributos do objeto JSON');
for(var att in customer)
{
    console.log(att);
}

// verificando se o atributo existe no objeto
console.log('O atributo name existe? R.' + customer.hasOwnProperty('name'));

console.log('');
console.log('Editando o valor do e-mail:')
customer.email = 'michael2012@email.com';
console.log('O novo e-mail é: ' + customer.email);


