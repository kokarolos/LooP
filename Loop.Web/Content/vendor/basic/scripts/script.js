jQuery(document).ready(function($) {
	
	"use strict";
	
//----- popup display on window load	
		function delay(){
			$(".popup-wraper.subscription").fadeIn();
		}
		window.setTimeout( delay, 3000 );
		
		$('.popup-closed').on('click', function() {
		  $('.popup-wraper.subscription').addClass('closed');
		  return false;
		});
	// popup end	
	
//------- Notifications Dropdowns
  $('.top-area > .setting-area > li > a').on("click",function(){
	 var $parent = $(this).parent('li');
	 $(this).addClass('active').parent().siblings().children('a').removeClass('active');
	 $parent.siblings().children('div').removeClass('active');
	 $(this).siblings('div').toggleClass('active');
	  	return false;
  });

  $("body *").not('.top-area > .setting-area > li > a').on("click", function() {
	 $(".top-area > .setting-area > li > a").removeClass('active');
	
 });
	
	
// New submit post box
	$(".new-postbox").click(function () {
	    $(".postoverlay").fadeIn(500);
	});
	$(".postoverlay").not(".new-postbox").click(function() {
	    $(".postoverlay").fadeOut(500);
	});
	$("[type = submit]").click(function () {
	    var post = $("textarea").val();
	    $("<p class='post'>" + post + "</p>").appendTo("section");
	});	
	
// top menu list	
	$('.main-menu > span').on('click', function () {
		$('.nav-list').slideToggle(300);
		
	});
	
// show comments	
	$('.comment').on('click', function () {
		$(this).parents(".post-meta").siblings(".coment-area").slideToggle("slow");
	});
	
// add / post location	
	$('.add-loc').on('click', function () {
		$('.add-location-post').slideToggle("slow");	
	});

// add popup upload from gallery	
	$('.from-gallery').on('click', function () {
		$('.already-gallery').addClass('active');
		
	});
	
	$('.canceld').on('click', function () {
		$('.already-gallery').removeClass('active');
	});
	
// Stories slide show
	$('.story-box').on('click', function () {
		$('.stories-wraper').addClass('active');
	});
		$('.close-story').on('click', function () {
		$('.stories-wraper').removeClass('active');
	});	

// add popup upload photo
	$('.edit-prof').on('click', function () {
		$('.popup-wraper').addClass('active');
	});
		$('.popup-closed').on('click', function () {
		$('.popup-wraper, .popup-wraper1').removeClass('active');
	});	
	
	// Create group friend
	$('.item-upload').on('click', function () {
		$('.popup-wraper4').addClass('active');
	});
		$('.popup-closed').on('click', function () {
		$('.popup-wraper4').removeClass('active');
	});	
	
	// Create group friend
	$('.item-upload.album').on('click', function () {
		$('.popup-wraper5').addClass('active');
	});
		$('.popup-closed').on('click', function () {
		$('.popup-wraper5').removeClass('active');
	});	
	
// popup event
	$('.event-title h4').on('click', function () {
		$('.popup-wraper7').addClass('active');
	});
	$('.popup-closed').on('click', function () {
		$('.popup-wraper7').removeClass('active');
	});
	
// chat messenger remove unread
	$('.msg-pepl-list .nav-item').on('click', function () {
		$(this).removeClass('unread');
	});	
	
// select gender on pitpoint page	
	$('.select-gender > li').click( function() {
		$(this).addClass('selected').siblings().removeClass('selected');
	  });
	
// select amount on donation page	
	$('.amount-select > li').click( function() {
		$(this).addClass('active').siblings().removeClass('active');
	  });
// select pay method on donation page	
	$('.pay-methods > li').click( function() {
		$(this).addClass('active').siblings().removeClass('active');
	  });	

// popup add user
	$('.user-add').on('click', function () {
		$('.popup-wraper6').addClass('active');
	});
	$('.popup-closed').on('click', function () {
		$('.popup-wraper6').removeClass('active');
		return false;
	});

// popup send message
	$('.send-mesg').on('click', function () {
		$('.popup-wraper1').addClass('active');
		return false;
	});
	
// popup report post
	$('.bad-report').on('click', function () {
		$('.popup-wraper3').addClass('active');
		return false;
	});
	$('.popup-closed, .cancel').on('click', function () {
		$('.popup-wraper3').removeClass('active');
		return false;
	});		
	
// comments popup
	jQuery(window).on("load", function(){
		$('.show-comt').bind('click', function () {
			$('.pit-comet-wraper').addClass('active');  
		});	
	});
// comments popup
	$('.add-pitrest > a, .pitred-links > .main-btn, .create-pst').on('click', function () {
		$('.popup-wraper').addClass('active');
		return false;
	});
	
// share post popup	
$('.share-pst').on('click', function () {
	$('.popup-wraper2').addClass('active');
	return false;
});
	$('.popup-closed, .cancel').on('click', function () {
	$('.popup-wraper2').removeClass('active');
});	
	
// messenger call popup
$('.audio-call, .video-call').on('click', function () {
		$('.call-wraper').addClass('active');
	});
		$('.decline-call, .later-rmnd').on('click', function () {
		$('.call-wraper').removeClass('active');
	});	
	
if ($.isFunction($.fn.toast)) {
	$.toast({
		heading: 'Welcome To Pitnik',
		text: '',
		showHideTransition: 'slide',
		icon: 'success',
		loaderBg: '#fa6342',
		position: 'bottom-right',
		hideAfter: 3000,
	});
	
	$.toast({
		heading: 'Information',
		text: 'Now you can full demo of pitnik and hope you like',
		showHideTransition: 'slide',
		icon: 'info',
		hideAfter: 5000,
		loaderBg: '#fa6342',
		position: 'bottom-right',
	});
	$.toast({
		heading: 'Support & Help',
		text: 'Report any <a href="#">issues</a> by email',
		showHideTransition: 'fade',
		icon: 'error',
		hideAfter: 7000,
		loaderBg: '#fa6342',
		position: 'bottom-right',
	});
}
		
// drag drop widget

	$( init );
	function init() {
	  $( ".droppable-area1, .droppable-area2" ).sortable({
	      connectWith: ".connected-sortable",
	      stack: '.connected-sortable ul'
	    }).disableSelection();
	}

//--- heart like and unlike 
	var counter = 0;
	var animated = false;
		$('.heart').click(function(){
		  if(!animated){
			$(this).addClass('happy').removeClass('broken');
			animated = true;
			counter++;
			$(this).children('span').text(counter);
		  }
		  else {
			$(this).removeClass('happy').addClass('broken');
			animated = false; 
			 counter--;
			$(this).children('span').text(counter);
		  }
		});	
	
// search fadein out at navlist area	
	$('.search-data').on('click', function () {
	  $( ".searchees" ).fadeIn( "slow", function() {
	  });
		return false;
	});
	
	$('.cancel-search').on('click', function () {
	  $( ".searchees" ).fadeOut( "slow", function() {
	  });
		return false;
	});	

//------- remove class active on body
	$("body *").not('.top-area > .setting-area > li > a').on("click", function() {
		$(".top-area > .setting-area > li > div").not('.searched').removeClass('active');
	});


//--- user setting dropdown on topbar	
$('.user-img').on('click', function() {
	$('.user-setting').toggleClass("active");
});

	
//--- side message box	
	$('.friendz-list > li, .chat-users > li, .drops-menu > li > a.show-mesg').on('click', function() {
		$('.chat-box').addClass("show");
		return false;
	});	
	$('.close-mesage').on('click', function() {
		$('.chat-box').removeClass("show");
		return false;
	});	
	
//------ scrollbar plugin
	if ($.isFunction($.fn.perfectScrollbar)) {
		$('.dropdowns, .twiter-feed, .invition, .followers, .chatting-area, .peoples, #people-list, .chat-list > ul, .message-list, .chat-users, .left-menu, .sugestd-photo-caro, .popup.events, .related-tube-psts, .music-list, .more-songs, .media > ul, .conversations, .msg-pepl-list, .menu-slide, .frnds-stories').perfectScrollbar();
	}

/*--- socials menu scritp ---*/	
	$('.trigger').on("click", function() {
	    $(this).parent(".menu").toggleClass("active");
	});
	
/*--- left menu full ---*/	
	$('.menu-small').on("click", function() {
	    $(".fixed-sidebar.left").addClass("open");
		
	  });
	$('.closd-f-menu').on("click", function() {
	    $(".fixed-sidebar.left").removeClass("open");
		
	  });

/*--- emojies show on text area ---*/	
	$('.add-smiles > span, .smile-it').on("click", function() {
	    $(this).siblings(".smiles-bunch").toggleClass("active");
	});
	
	$('.smile-it').on("click", function() {
	    $(this).children(".smiles-bunch").toggleClass("active");
	});
	
//save post click	
$('.save-post, .bane, .get-link').on("click", function() {
	    $(this).toggleClass("save");
	});
	
// delete notifications
	$('.notification-box > ul li > i.del').on("click", function(){
	    $(this).parent().slideUp();
		return false;
	}); 	

/*--- socials menu scritp ---*/	
	$('.f-page > figure i').on("click", function() {
	    $(".drop").toggleClass("active");
	});

	
//select photo in upload photo popup	
	$('.sugestd-photo-caro > li').on('click', function() {
		$(this).toggleClass('active');			
		return false;
	});
	
//--- pitred point adding
	$('.minus').click(function () {
		var $input = $(this).parent().find('input');
		
		$('.minus').on("click", function() {
			$(this).siblings('input').removeClass("active");
			$(this).siblings('.plus').removeClass("active");
			
		});
		
		var count = parseInt($input.val()) - 1;
		count = count < 1 ? 0 : count;
		$input.val(count);
		$input.change();
		return false;
	});
	
   $('.plus').click(function () {
		var $input = $(this).parent().find('input');
		
		$('.plus').on("click", function() {
			$(this).addClass("active");
			$(this).siblings('input').addClass("active");
		});
		$input.val(parseInt($input.val()) + 1);
		$input.change();
		return false;
	});

//Link copied on click 	

	$(".get-link").click(function (event) {
		event.preventDefault();
		CopyToClipboard("This is some test value.", true, "Link copied");
	});

	function CopyToClipboard(value, showNotification, notificationText) {

		var $temp = $("<input>");
		$("body").append($temp);
		$temp.val(value).select();
		document.execCommand("copy");
		$temp.remove();

		if (typeof showNotification === 'undefined') {
			showNotification = true;
		}
		if (typeof notificationText === 'undefined') {
			notificationText = "Copied to clipboard";
		}

		var notificationTag = $("div.copy-notification");
		if (showNotification && notificationTag.length == 0) {
			notificationTag = $("<div/>", { "class": "copy-notification", text: notificationText });
			$("body").append(notificationTag);

			notificationTag.fadeIn("slow", function () {
				setTimeout(function () {
					notificationTag.fadeOut("slow", function () {
						notificationTag.remove();
					});
				}, 1000);
			});
		}
	}

	
//===== Search Filter =====//
	(function ($) {
	// custom css expression for a case-insensitive contains()
	jQuery.expr[':'].Contains = function(a,i,m){
	  return (a.textContent || a.innerText || "").toUpperCase().indexOf(m[3].toUpperCase())>=0;
	};

	function listFilter(searchDir, list) { 
	  var form = $("<form>").attr({"class":"filterform","action":"#"}),
	  input = $("<input>").attr({"class":"filterinput","type":"text","placeholder":"Search Contacts..."});
	  $(form).append(input).appendTo(searchDir);

	  $(input)
	  .change( function () {
		var filter = $(this).val();
		if(filter) {
		  $(list).find("li:not(:Contains(" + filter + "))").slideUp();
		  $(list).find("li:Contains(" + filter + ")").slideDown();
		} else {
		  $(list).find("li").slideDown();
		}
		return false;
	  })
	  .keyup( function () {
		$(this).change();
	  });
	}

//search friends widget
	$(function () {
	  listFilter($("#searchDir"), $("#people-list"));
	});
	}(jQuery));	

//progress line for page loader
	$('body').show();
	NProgress.start();
	setTimeout(function() { NProgress.done(); $('.fade').removeClass('out'); }, 2000);
	
//--- bootstrap tooltip and popover	
	$(function () {
	  $('[data-toggle="tooltip"]').tooltip();
		$('[data-toggle="popover"]').popover();
	});
	
// Sticky Sidebar & header
	if($(window).width() < 981) {
		$(".sidebar").children().removeClass("stick-widget");
	}

	if ($.isFunction($.fn.stick_in_parent)) {
		$('.stick-widget').stick_in_parent({
			parent: '#page-contents',
			offset_top: 60,
		});

		
		$('.stick').stick_in_parent({
		    parent: 'body',
            offset_top: 0,
		});
		
	}
	
/*--- topbar setting dropdown ---*/	
	$(".we-page-setting").on("click", function() {
	    $(".wesetting-dropdown").toggleClass("active");
	});	
	  
/*--- topbar toogle setting dropdown ---*/	
$('#nightmode').on('change', function() {
    if ($(this).is(':checked')) {
        // Show popup window
        $(".theme-layout").addClass('black');	
    }
	else {
        $(".theme-layout").removeClass("black");
    }
});

//chosen select plugin
	if ($.isFunction($.fn.chosen)) {
		$("select").chosen();
	}

//----- add item plus minus button
	if ($.isFunction($.fn.userincr)) {
		$(".manual-adjust").userincr({
			buttonlabels:{'dec':'-','inc':'+'},
		}).data({'min':0,'max':20,'step':1});
	}	
	
if ($.isFunction($.fn.loadMoreResults)) {	
	$('.loadMore').loadMoreResults({
		displayedItems: 3,
		showItems: 1,
		button: {
		  'class': 'btn-load-more',
		  'text': 'Load More'
		}
	});	
	
	$('.load-more').loadMoreResults({
		displayedItems: 8,
		showItems: 1,
		button: {
		  'class': 'btn-load-more',
		  'text': 'Load More'
		}
	});
	
	$('.load-more4').loadMoreResults({
		displayedItems: 8,
		showItems: 1,
		button: {
		  'class': 'btn-load-more',
		  'text': 'Load More'
		}
	});
}
	//===== owl carousel  =====//
	if ($.isFunction($.fn.owlCarousel)) {
		$('.sponsor-logo').owlCarousel({
			items: 6,
			loop: true,
			margin: 30,
			autoplay: true,
			autoplayTimeout: 1500,
			smartSpeed: 1000,
			autoplayHoverPause: true,
			nav: false,
			dots: false,
			responsiveClass:true,
				responsive:{
					0:{
						items:3,
					},
					600:{
						items:3,

					},
					1000:{
						items:6,
					}
				}

		});
		
		//contributors on tube channel
		$('.contributorz').owlCarousel({
			items: 6,
			loop: true,
			margin: 20,
			autoplay: true,
			autoplayTimeout: 1500,
			smartSpeed: 1000,
			autoplayHoverPause: true,
			nav: false,
			dots: false,
			responsiveClass:true,
				responsive:{
					0:{
						items:2,
					},
					600:{
						items:3,

					},
					1000:{
						items:6,
					}
				}

		});
		
		/*--- timeline page ---*/
		$('.suggested-frnd-caro').owlCarousel({
			items: 4,
			loop: true,
			margin: 10,
			autoplay: false,
			autoplayTimeout: 1500,
			smartSpeed: 1000,
			autoplayHoverPause: true,
			nav: true,
			dots: false,
			responsiveClass:true,
			responsive:{
				0:{
					items:1,
				},
				600:{
					items:4,

				},
				1000:{
					items:4,
				}
			}
		});
		
		$('.frndz-list').owlCarousel({
			items: 5,
			loop: true,
			margin: 10,
			autoplay: false,
			autoplayTimeout: 1500,
			smartSpeed: 1000,
			autoplayHoverPause: true,
			nav: true,
			dots: false,
			responsiveClass:true,
				responsive:{
					0:{
						items:2,
					},
					600:{
						items:3,

					},
					1000:{
						items:5,
					}
				}
		});
		
		$('.photos-list').owlCarousel({
			items: 5,
			loop: true,
			margin: 10,
			autoplay: false,
			autoplayTimeout: 1500,
			smartSpeed: 1000,
			autoplayHoverPause: true,
			nav: true,
			dots: false,
			responsiveClass:true,
				responsive:{
					0:{
						items:2,
					},
					600:{
						items:3,

					},
					1000:{
						items:5,
					}
				}
		});
		
		$('.videos-list').owlCarousel({
			items: 3,
			loop: true,
			margin: 30,
			autoplay: false,
			autoplayTimeout: 1500,
			smartSpeed: 1000,
			autoplayHoverPause: true,
			nav: true,
			dots: false,
			responsiveClass:true,
				responsive:{
					0:{
						items:1,
					},
					600:{
						items:2,

					},
					1000:{
						items:3,
					}
				}
		});
		
		//Badges carousel on badges page
		$('.badge-caro').owlCarousel({
			items: 6,
			loop: true,
			margin: 30,
			autoplay: false,
			autoplayTimeout: 1500,
			smartSpeed: 1000,
			autoplayHoverPause: true,
			nav: true,
			dots: false,
			center:true,
			responsiveClass:true,
				responsive:{
					0:{
						items:1,
					},
					600:{
						items:4,

					},
					1000:{
						items:6,
					}
				}
		});
		
		// Related groups on groups page
		$('.related-groups').owlCarousel({
			items: 6,
			loop: true,
			margin: 50,
			autoplay: false,
			autoplayTimeout: 1500,
			smartSpeed: 1000,
			autoplayHoverPause: true,
			nav: true,
			dots: false,
			center:false,
			responsiveClass:true,
				responsive:{
					0:{
						items:2,
						margin: 10,
					},
					600:{
						items:3,

					},
					1000:{
						items:6,
					}
				}
		});
		
		// trending pitred posts
		$('.pitred-trendings.six').owlCarousel({
			items: 6,
			loop: true,
			margin: 20,
			autoplay: false,
			autoplayTimeout: 1500,
			smartSpeed: 1000,
			autoplayHoverPause: true,
			nav: true,
			dots: false,
			center:false,
			responsiveClass:true,
				responsive:{
					0:{
						items:2,
						margin: 10,
					},
					600:{
						items:3,

					},
					1000:{
						items:6,
					}
				}
		});
		
		// trending pitred posts
		$('.pitred-trendings').owlCarousel({
			items: 4,
			loop: true,
			margin: 20,
			autoplay: false,
			autoplayTimeout: 1500,
			smartSpeed: 1000,
			autoplayHoverPause: true,
			nav: true,
			dots: false,
			center:false,
			responsiveClass:true,
				responsive:{
					0:{
						items:2,
						margin: 10,
					},
					600:{
						items:3,

					},
					1000:{
						items:4,
					}
				}
		});
		
		// Success couples caro in pitpoint page
		$('.succes-people').owlCarousel({
			items: 1,
			loop: true,
			margin: 0,
			autoplay: true,
			autoplayTimeout: 1500,
			smartSpeed: 1000,
			autoplayHoverPause: true,
			nav: false,
			dots: true,
			center:false,
			responsiveClass:true,
				responsive:{
					0:{
						items:1,
					},
					600:{
						items:1,

					},
					1000:{
						items:1,
					}
				}
		});
		
		// Featured area fade caro soundnik page
		$('.soundnik-featured').owlCarousel({
			items: 1,
			loop: true,
			margin: 0,
			autoplay: true,
			autoplayTimeout: 1500,
			smartSpeed: 1000,
			autoplayHoverPause: true,
			nav: false,
			dots: true,
			center:false,
			animateOut: 'fadeOut',
            animateIn: 'fadein',
			responsiveClass:true,
				responsive:{
					0:{
						items:1,
					},
					600:{
						items:1,

					},
					1000:{
						items:1,
					}
				}
		});
		
		// Promo Caro classified page
		$('.promo-caro').owlCarousel({
			items: 3,
			loop: true,
			margin: 10,
			autoplay: false,
			autoplayTimeout: 1500,
			smartSpeed: 1000,
			autoplayHoverPause: true,
			nav: true,
			dots: false,
			center:false,
			responsiveClass:true,
				responsive:{
					0:{
						items:2,
					},
					600:{
						items:2,

					},
					1000:{
						items:3,
					}
				}
		});
		
	// Promo Caro classified page
		$('.testi-caro').owlCarousel({
			items: 1,
			loop: true,
			margin: 0,
			autoplay: true,
			autoplayTimeout: 1500,
			smartSpeed: 1000,
			autoplayHoverPause: true,
			nav: false,
			dots: false,
			center:false,
			responsiveClass:true,
				responsive:{
					0:{
						items:1,
					},
					600:{
						items:1,

					},
					1000:{
						items:1,
					}
				}
		});	
		
	//featured-text-caro
		$('.text-caro').owlCarousel({
			items:1,
			loop:true,
			margin:0,
			autoplay:true,
			autoplayTimeout:2500,
			autoplayHoverPause:true,
			dots:false,
			nav:false,
			animateIn:'fadeIn',
			animateOut:'fadeOut',
		});
		
	//sponsors carousel	
		$('.sponsors').owlCarousel({
			loop:true,
			margin:80,
			smartSpeed: 1000,
			responsiveClass:true,
			nav:true,
			dots:false,
			autoplay:true,
			responsive:{
				0:{
					items:1,
					nav:false,
					dots:false
				},
				600:{
					items:3,
					nav:false
				},
				1000:{
					items:5,
					nav:false,
					dots:false
				}
			}
		});
		
	//team section carousel
		$('.team-carouzel').owlCarousel({
			loop:true,
			margin:28,
			smartSpeed: 1000,
			responsiveClass:true,
			nav:true,
			dots:false,
			responsive:{
				0:{
					items:1,
					nav:false,
					dots:false
				},
				600:{
					items:2,
					nav:true
				},
				1000:{
					items:3,
					nav:true,
				}
			}
		});
		
	}
	
// slick carousel for detail page
	if ($.isFunction($.fn.slick)) {
		$('.slick-single').slick();

    $('.slick-multiple').slick({
        infinite: true,
        slidesToShow: 4,
        slidesToScroll: 4
    });

    $('.slick-autoplay').slick({
        slidesToShow: 3,
        slidesToScroll: 1,
        autoplay: true,
        autoplaySpeed: 2000,
    });

    $('.slick-center-mode').slick({
        centerMode: true,
        centerPadding: '60px',
        slidesToShow: 3,
        responsive: [
            {
				breakpoint: 768,
				settings: {
					arrows: false,
					centerMode: true,
					centerPadding: '40px',
					slidesToShow: 3
				}
            },
            {
                breakpoint: 480,
                settings: {
                    arrows: false,
                    centerMode: true,
                    centerPadding: '40px',
                    slidesToShow: 1
                }
            }
        ]
    });

    $('.slick-fade-effect').slick({
        dots: true,
        infinite: true,
        speed: 500,
        fade: true,
        cssEase: 'linear'
    });
		

    $('.slider-for').slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        arrows: false,
        fade: true,
        asNavFor: '.slider-nav'
    });

    $('.slider-nav').slick({
        slidesToShow: 4,
        slidesToScroll: 1,
        asNavFor: '.slider-for',
        centerMode: true,
        focusOnSelect: true
    });
	$('.slider-for-gold').slick({
		slidesToShow: 1,
		slidesToScroll: 1,
		arrows: false,
		slide: 'li',
		fade: false,
		asNavFor: '.slider-nav-gold'
	});

	$('.slider-nav-gold').slick({
		slidesToShow: 3,
		slidesToScroll: 1,
		asNavFor: '.slider-for-gold',
		dots: false,
		arrows: false,
		slide: 'li',
		vertical: true,
		centerMode: true,
		centerPadding: '0',
		focusOnSelect: true,
		responsive: [
		{
			breakpoint: 768,
			settings: {
				slidesToShow: 3,
				slidesToScroll: 1,
				infinite: true,
				vertical: false,
				centerMode: true,
				dots: false,
				arrows: false
			}
		},
		{
			breakpoint: 641,
			settings: {
				slidesToShow: 2,
				slidesToScroll: 1,
				infinite: true,
				vertical: false,
				centerMode: true,
				dots: false,
				arrows: false
			}
		}
		]
	});
}

//---- calander	
	if ($.isFunction($.fn.jalendar)) { 
	 $('#yourId').jalendar({
			customDay: '11/01/2015',
			color: '#577e9a', // Unlimited Colors
			color2: '#57c8bf', // Unlimited Colors
			lang: 'EN',
			sundayStart: true
		});
	}
	
//---- responsive header
if ($.isFunction($.fn.mmenu)) {
	$(function() {

		//	create the menus
		$('#menu').mmenu();
		$('#shoppingbag').mmenu({
			navbar: {
				title: 'General Setting'
			},
			offCanvas: {
				position: 'right'
			}
		});

		//	fire the plugin
		$('.mh-head.first').mhead({
			scroll: {
				hide: 200
			}

		});
		$('.mh-head.second').mhead({
			scroll: false
		});
	});	
}

//**** Slide Panel Toggle ***//
	$("span.main-menu").on("click", function(){
	     $(".side-panel").toggleClass('active');
		  $(".theme-layout").toggleClass('active');
		  return false;
	});

	$('.theme-layout').on("click",function(){
		  $(this).removeClass('active');
	     $(".side-panel").removeClass('active');
	});

	  
// login & register form
	$('button.signup').on("click", function(){
		$('.login-reg-bg').addClass('show');
		return false;
	});
	  
	$('.already-have').on("click", function(){
		$('.login-reg-bg').removeClass('show');
		return false;
	});
	
//----- count down timer		
	if ($.isFunction($.fn.downCount)) {
		$('.countdown').downCount({
			date: '11/12/2021 12:00:00',
			offset: +10
		});
	}
	
//counter for funfacts
		if ($.isFunction($.fn.counterUp)) {
		$('.counter').counterUp({
			delay: 10,
			time: 1000
		});
		}	
/** Post a Comment **/
jQuery(".post-comt-box textarea").on("keydown", function(event) {

	if (event.keyCode == 13) {
		var comment = jQuery(this).val();
		var parent = jQuery(".showmore").parent("li");
		var comment_HTML = '<li><div class="comet-avatar"><img alt="" src="images/resources/comet-2.jpg"></div><div class="we-comment"><h5><a title="" href="time-line.html">Sophia</a></h5><p>'+comment+'</p><div class="inline-itms"><span>1 minut ago</span><a title="Reply" href="#" class="we-reply"><i class="fa fa-reply"></i></a><a title="" href="#"><i class="fa fa-heart"></i></a></div></div></li>';
		$(comment_HTML).insertBefore(parent);
		jQuery(this).val('');
	}
}); 
	
//inbox page 	
//***** Message Star *****//  
    $('.message-list > li > span.star-this').on("click", function(){
    	$(this).toggleClass('starred');
    });


//***** Message Important *****//
    $('.message-list > li > span.make-important').on("click", function(){
    	$(this).toggleClass('important-done');
    });

    

// Listen for click on toggle checkbox
	$('#select_all').on("click", function(event) {
	  if(this.checked) {
	      // Iterate each checkbox
	      $('input:checkbox.select-message').each(function() {
	          this.checked = true;
	      });
	  }
	  else {
	    $('input:checkbox.select-message').each(function() {
	          this.checked = false;
	      });
	  }
	});
// delete email from messages
	$(".delete-email").on("click",function(){
		$(".message-list .select-message").each(function(){
			  if(this.checked) {
			  	$(this).parent().slideUp();
			  }
		});
	});

// change background color on hover
	/*$('.category-box').hover(function () {
		$(this).addClass('selected');
		$(this).parent().siblings().children('.category-box').removeClass('selected');
	});*/
	
	
// Responsive nav dropdowns
	$('li.menu-item-has-children > a').on('click', function () {
		$(this).parent().siblings().children('ul').slideUp();
		$(this).parent().siblings().removeClass('active');
		$(this).parent().children('ul').slideToggle();
		$(this).parent().toggleClass('active');
		return false;
	});
	
// Slider box
	$(function() {
	  $("#price-range").slider({
		range: "max",
		min: 18, // Change this to change the min value
		max: 65, // Change this to change the max value
		value: 18, // Change this to change the display value
		step: 1, // Change this to change the increment by value.
		slide: function(event, ui) {
		  $("#priceRange").val(ui.value + " Years");
		}
	  });
	  $("#priceRange").val( $("#price-range").slider("value") + " Years");
	});
//--- range slider 	
 $( function() {
		$( "#slider-range" ).slider({
		  range: true,
		  min: 0,
		  max: 500,
		  values: [ 75, 300 ],
		  slide: function( event, ui ) {
			$( "#amount" ).val( "$" + ui.values[ 0 ] + " - $" + ui.values[ 1 ] );
		  }
		});
		$( "#amount" ).val( "$" + $( "#slider-range" ).slider( "values", 0 ) +
		  " - $" + $( "#slider-range" ).slider( "values", 1 ) );
	  } );
});//document ready end

/*--- progress circle with percentage ---*/
(function() {
	
	window.onload = function() {
    var totalProgress, progres;
		const circles = document.querySelectorAll('.progres');
		for(var i = 0; i < circles.length; i++) {
			totalProgress = circles[i].querySelector('circle').getAttribute('stroke-dasharray');
			progress = circles[i].parentElement.getAttribute('data-percent');
      circles[i].querySelector('.bar').style['stroke-dashoffset'] = totalProgress * progress / 100;
      
		}
	};
})();


	





