$( document ).ready(function() {
    $("#option-icon").click(function(){
    	$("#option-full").fadeIn( "slow" );
    	$("#option-icon").fadeOut( "slow" );
    });
    // function chi hien thi cho member dat hang
    // $("#food-icon").show();
    // $("#food-icon").click(function(){
    // 	$("#food-full").fadeIn( "slow" );
    // 	$("#food-icon").fadeOut( "slow" );
    // });
    // $(".so-luong-food").click(function(){
    // 	var height_body = $("body").height();
    // 	$("#bg-light-box").css("height",height_body);
    // 	$("#bg-light-box").fadeIn( "slow" );
    // 	$("#so-luong-change").fadeIn( "slow" );
    // 	$("#light-box").fadeIn( "slow" );
    // });
    // $(".note").click(function(){
    // 	var height_body = $("body").height();
    // 	$("#bg-light-box").css("height",height_body);
    // 	$("#bg-light-box").fadeIn( "slow" );
    // 	$("#note-change").fadeIn( "slow" );
    // 	$("#light-box").fadeIn( "slow" );
    // });
    $('body').on("click", "section", function(event){
		var target = $( event.target );
		if(!target.parents('#option').length == 1 && $('#option-full').is(':visible') ){
			$("#option-full").fadeOut( "slow" );
    		$("#option-icon").fadeIn( "slow" );
		}
		if(!target.parents('#menu-food-main').length == 1 && !target.parents('#light-box').length == 1 && $('#food-full').is(':visible')){
			$("#food-full").fadeOut( "slow" );
    		$("#food-icon").fadeIn( "slow" );
		}
		// function chi hien thi cho member dat hang
		// if(!target.parents('#so-luong-change').length == 1 && $('#so-luong-change').is(':visible') && !target.is('#so-luong-change') && !target.is('.so-luong-food') ){
		// 	$("#light-box").fadeOut( "slow" );
		// 	$("#so-luong-change").fadeOut( "slow" );
		// 	$("#bg-light-box").fadeOut( "slow" );
		// }
		// if(!target.parents('#note-change').length == 1 && $('#note-change').is(':visible') && !target.is('#note-change') && !target.parents('.note-food').length == 1 ){
		// 	$("#light-box").fadeOut( "slow" );
		// 	$("#note-change").fadeOut( "slow" );
		// 	$("#bg-light-box").fadeOut( "slow" );
		// }

	});
	$("#show-login").click(function(){
    	$("#username").toggle( "slow" );
    	$("#password").toggle( "slow" );
    	if($("#icon-show-more>i").hasClass("glyphicon-chevron-down")){
    		$(".glyphicon-chevron-down").toggleClass('glyphicon-chevron-down glyphicon-chevron-up');
    	} else {
    		$(".glyphicon-chevron-up").toggleClass('glyphicon-chevron-up glyphicon-chevron-down');
    	}
    });
});