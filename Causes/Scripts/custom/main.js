$(document).ready(function () {


    // Cards handlers
    //Switch tab content
    $(".action").click((event) => {
        //alert("Action handler is working");
        event.preventDefault();

        let $thisCard = $(event.currentTarget).parent().parent().parent().parent();

        $thisCard.find(".action-content").removeClass('collapse');
        $thisCard.find(".cause-content").addClass('collapse');

        //Switch active tab - cosmetic
        let $this = event.currentTarget;

        $($this).addClass('active');
        $($thisCard).find('.cause').removeClass('active');
        //End Switch

    })
    //Switch tab content
    $(".cause").click((event) => {

        //alert("Cause handler is working");
        event.preventDefault();

        let $thisCard = $(event.currentTarget).parent().parent().parent().parent();
        $thisCard.find(".action-content").addClass("collapse");
        $thisCard.find(".cause-content").removeClass("collapse");

        //Switch active tab - cosmetic
        let $this = event.currentTarget;

        $($this).addClass('active');
        $($thisCard).find('.action').removeClass('active');
        //End Switch
    })
});


// All Below is the jQuery code developed for the previous front-end which I did not integrate in the asp.net views
/*
 * 
// Main navigation handlers

    // Bottom border nav
    $(".nav-item").on('click', (event)=>{
        var $toActivate = $(event.currentTarget);
        var $siblings = $toActivate.siblings();
        
        // alert("Nav-item handler is working");

        $toActivate.addClass('border-bottom border-primary');
        $siblings.removeClass('border-bottom border-primary');

    })
    //End

    //Navigation through main content divs
    $('.get-home').click(function(){
        // alert('Nav home is working');

        let $dest = $('.home');

        $('.content-main').addClass('collapse');          
        $dest.removeClass('collapse');
    
    });

    $('.get-list').click(function(){
        // alert('Nav list is working');

        let $dest = $('.list');
        $('.content-main').addClass('collapse');          
        $dest.removeClass('collapse');
    
    });
    
    $('.get-join').click(function(){
        // alert('Nav join is working');

        let $dest = $('.join');
        $('.content-main').addClass('collapse');          
        $dest.removeClass('collapse');
    
    });

    $('.get-account').click(function(){
        // alert('Nav account is working');
        $(".login-menu").toggle();

        let $dest = $('.account');
        $('.content-main').addClass('collapse');          
        $dest.removeClass('collapse');
    
    });


// End Main navigation



    // Card details
    $('.get-card-details').click(function(){
        // alert('Go to details is working');

        let $dest = $('.card-details');
        $('.list').addClass('collapse');          
        $dest.removeClass('collapse');
    
    });
    // End card details

    //Join button responsive

    $(".btn-join").one('click', (event)=>{
        $button = $(event.currentTarget)

        $button.removeClass("btn-info");
        $button.addClass("btn-success");

        $count = $button.next('.follower-count');
        let count = parseInt($count.html());
        count++;
        $count.html(count);



    })

    //End Join button



// End cards handlers

// Account page handlers

    $('#content-main').click((event)=>{
        $(event.currentTarget).removeClass('d-none');
        $(event.currentTarget).siblings().addClass('d-none');
        alert('working');
    })

    $(".details-btn").click(()=>{
        $(".details-cnt").removeClass("d-none");
        $(".details-cnt").siblings().addClass("d-none");
    })

    $(".followed-btn").click(()=>{
        $(".followed-cnt").removeClass("d-none");
        $(".followed-cnt").siblings().addClass("d-none");
    })

    $(".created-btn").click(()=>{
        $(".created-cnt").removeClass("d-none");
        $(".created-cnt").siblings().addClass("d-none");
    })

    $(".delete-btn").click(function(){
        if(confirm("Are you sure you want to delete this?")){
            alert("Account deleted!");
        }
        else{
            return false;
        }
    });
// End Account Page Handlers

// Join Form Validation

$('#join-form').validate({ // initialize the plugin
    // alert("Validation is working");

    rules: {
        email: {
            required: true,
            email: true
        },
        password: {
            required: true,
            minlength: 5
        }
    }
});

// End form validation

}); 

*/

