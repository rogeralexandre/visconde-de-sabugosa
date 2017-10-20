// exemplo simples de função callback
console.log('Chamando uma função simples de Callback');
function perform(a,b,callback)
{
    var c = a*b;
    callback(c);
}
//chamando a função perform.
perform(10,5,function(result){
                             console.log(result);
                             })

console.log('Chamando uma função Callback que retorna erro');
function perform2(a,b,callback)
{
    // faz algum processamento
    // exemplo faria a mesma conta que do exemplo anterior.
    var errorcode = 102;
    //aqui está retornando dois parâmetros.
    callback(errorcode, 'Internal server error');
}
// chamando a função perform2
perform2(10,5,function(errCode,msg){
    if(errCode){
        console.log('código de erro:' + errCode + ' mensagem:' + msg);
    }
    else
    {
        console.log('não deu erro');
    }
})