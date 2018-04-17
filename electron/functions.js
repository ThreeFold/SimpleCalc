
function appendNumber(num){
    var input = document.getElementById("numberBox");
   input.value += num;
  }

function evaluateNumberBox(){
    var input = document.getElementById("numberBox");
    input.value = eval(input.value);
}
function append(val){
    
    var input = document.getElementById("numberBox");
    input.value += val;
}
function appendPlus(){
    append("+");
}
function appendDash(){
    append("-");
}
function appendMultiply(){
    append("*");
}
function appendDiv(){
    append("/");
}
