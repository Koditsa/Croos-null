//Script for "rendering" frontend
window.onload = function () {

    

    $(function () {
        modal1.style.display = "block";
    });
    

    for (var i = 0; i < 9; i++) {
        document.getElementById('game').innerHTML += '<div ' + 'id="' + i + '" class = "block"></div>'
    }

    var iteration = 1;//номер хода
    var t = new Array(9);
    $(function () {
        $('.block').click(function (e) {
            if (iteration % 2 == 0) {
                $(this).toggleClass('push_pig');
                move(this.id, 'PIG')
            } else {
                $(this).toggleClass('push_bird');
                move(this.id, 'BIRD')
            }
            iteration++;
        });
    });

    function move(id, role) {
        t[id] = role;
        !cheked() ? (role == 'PIG') ? (role == 'BIRD') : null : reset(role)
    }

    function reset(role) {
        t = [];
        alert("Игра окончена! Победу одержали " + role);
        modal2.style.display = "block";
        $.post("https://localhost:44375/Home/AddWinnerToBd", { suggest: role }, function (result) {
            $("span").html(result);
        });
    }

    function cheked() {
        if (t[0] == 'PIG' && t[1] == 'PIG' && t[2] == 'PIG' || t[0] == 'BIRD' && t[1] == 'BIRD' && t[2] == 'BIRD') return true;
        if (t[3] == 'PIG' && t[4] == 'PIG' && t[5] == 'PIG' || t[3] == 'BIRD' && t[4] == 'BIRD' && t[5] == 'BIRD') return true;
        if (t[6] == 'PIG' && t[7] == 'PIG' && t[8] == 'PIG' || t[6] == 'BIRD' && t[7] == 'BIRD' && t[8] == 'BIRD') return true;
        if (t[0] == 'PIG' && t[3] == 'PIG' && t[6] == 'PIG' || t[0] == 'BIRD' && t[3] == 'BIRD' && t[6] == 'BIRD') return true;
        if (t[1] == 'PIG' && t[4] == 'PIG' && t[7] == 'PIG' || t[1] == 'BIRD' && t[4] == 'BIRD' && t[7] == 'BIRD') return true;
        if (t[2] == 'PIG' && t[5] == 'PIG' && t[8] == 'PIG' || t[2] == 'BIRD' && t[5] == 'BIRD' && t[8] == 'BIRD') return true;
        if (t[0] == 'PIG' && t[4] == 'PIG' && t[8] == 'PIG' || t[0] == 'BIRD' && t[4] == 'BIRD' && t[8] == 'BIRD') return true;
        if (t[2] == 'PIG' && t[4] == 'PIG' && t[6] == 'PIG' || t[2] == 'BIRD' && t[4] == 'BIRD' && t[6] == 'BIRD') return true;
        if (t[0] && t[1] && t[2] && t[3] && t[4] && t[5] && t[6] && t[7] && t[8]) return true;
    }

    //Modal Window
    var modal1 = document.getElementById('modalWindow');
    var modal2 = document.getElementById('modalMenu');
    var modalStatistic = document.getElementById('modalStat');
    var btn = document.getElementById('btn');
    var btn_back = document.getElementById('btn_back');


    $(function () {
        $('.gamer').click(function () {
            modal1.style.display = "none";
            btn.style.display = "block";
        });
    });

    $(function () {
        $('.button_menu').click(function () {
            btn.style.display = "none";
            modal2.style.display = "block";
        });
    });

    $(function () {
        $('.regamer').click(function () {
            $('.block').toggleClass('push_pig push_bird', false)
            modal2.style.display = "none";
            btn.style.display = "block";
        });
    });

    $(function () {
        $('.statistic').click(function () {
            modal2.style.display = "none";
            modalStatistic.style.display = "block";
            btn_back.style.display = "block";
        });
    });

    $(function () {
        $('.back_btn').click(function () {
            modalStatistic.style.display = "none";
            btn.style.display = "block";
        });
    });

}
