
window.onload = function(){
    for(var i = 0; i < 9; i++){
        document.getElementById('game').innerHTML+='<div class = "block"></div>'
    }

    var iteration = 0;//номер хода

    $(function() {  
            $('.block').click(function(){
                if(iteration % 2 == 0){
                    $(this).toggleClass('push_pig');
                }else{
                    $(this).toggleClass('push_bird');
                }
                iteration++;
            });        
    });

}
