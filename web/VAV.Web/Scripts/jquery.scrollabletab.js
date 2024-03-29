/**
 * jQueryUI.ScrollableTabs - Scrolling multiple tabs.
 * @copyright jQueryUI.scrollableTabs is licensed under the WTFPL (so feel free to relicense as needed).
 * Date: 16/05/2011
 * @author Aamir Afridi - aamirafridi(at)gmail(dot)com | http://www.aamirafridi.com
 * @version 2.0
 * Examples:
 *    $('#example_1').tabs({paging: true});
 *    $('#example_2').tabs({paging: {options} });
 */
 

 /*
 TODO:
 	1.	Re-position tabs when user add or remove a tab. at the moment its working fine but there is something wrong when you keep removing and adding tabs.
		When user close the last tab, the tabs should navigate and adjust itself to fill the empty space at the end. When it comes to last tab, user can still close it using jQuery UI tab's method
		so in that case there might be a problem if user want to add a new tab.
		When user adds a tab, the tab should adjust its position at the end and depending on option, should navigate to it the new tab or not.
	2.	I LOVE THIS FEATURE but can leave this till end. Just like chrome if user want to close a tab, soon user clicks the close button, the next tab should navigate and its close button
		should come under the pointer so user can keep clicking to close the tabs. (open many tabs in chrome and try closing them without moving ur mouse pointer)
	3.	I tried to make sure that all the calculations should be done without any hard coding css values so make sure the plugin works even if user use larger font sizes for tabs and its content
	4.	Test on other browsers, including IE/6
	5.	Improve the performance and speed but don't care too much as we shouldn't change the markup as in previous version, i did for this plugin
	6.	I arrange the plugin by setting their css left position and than scroll them by animating its margin-left in negative(next/last) or positive(prev/first).
		I used css left because tabs cannot be adjusted if we use float:left in one line so i used the overflow:hidden for the UL and let them positioned absolutely inside.
	7.	Think of more callbacks if user wants like I have just one onTabScroll (not tested yet :P )
	8.	Exponse _animateTo.. method as $tabs.scrollToTab(tabIndex,callback etc)
	9.	Test if user want to load with ajax content
	10.	These features are OSUM: http://stackoverflow.com/questions/2475725/jquery-ui-tabs-customization-for-many-tabs BY Tauren
	11. If there is a problem with IE8 as I discovered in previous version, tabs will disappear when user add a tab. try alltabs.hide().show() should work
	12. http://jsfiddle.net/BYS2U/6/ (see last lines on this file) basically should be able to do something like $('#mytabs').tabs({...,scrollable:{opts},....})
	13. All feature request that are made on http://aamirafridi.com/jquery/jquery-scrollable-tabs comments
	14. Any cool-easy-to-implement features you can think of
 */
 
;(function($){
	var settings = {
		'animateTabs' : false, // THIS CAN KILL IE6 WHEN THERE ARE MANY TABS :(  When tabs loaded and when user close the tab and the rest adjust its position
		'showNavWhenNeeded': true, //false: always show no matter if there are few tabs.
		'customNavNext' : null,
		'customNavPrev' : null,
		'customNavFirst' : null,
		'customNavLast' : null,
		'closable' : true, //Make tabs closable
		'easing':'swing', //The easing equation
		'loadLastTab':false, //When tabs loaded, scroll to the last tab - default is the first tab
		'onTabScroll' : function(){},
		'resizable' : false, //Alow resizing the tabs container
		'resizeHandles' : 'e,s,se', //Resizable in North, East and NorthEast directions
		'scrollSpeed' : 500, //The speed in which the tabs will animate/scroll
		'selectTabOnAdd' : true,
		'selectTabAfterScroll' : true,
		'showFirstLastArrows' : false,
		'hideDefaultArrows' : false,
		'nextPrevOutward'	: false,
		'wrapperCssClass' : '',
		'onTabActive':null
	}
$.fn.scrollabletabs = function(options)
{
    return this.each(function(){		
		var o = $.extend({}, settings, typeof options=='object' ? options : {} ),
			$tabs = $(this).addClass(o.wrapperCssClass+' stMainWrapper'),
			$ul = $tabs.find('ul.ui-tabs-nav:first'),
			$lis = $ul.find('li'),
			$arrowsNav = $('<ol class="stNavMain" />'),
			$curSelectedTab = $ul.find('.ui-tabs-active').addClass('stCurrentTab'); //We will use our own css class to detect a selected tab because we might want to scroll without tab being selected
        	if(!o.hideDefaultArrows)
			{
				var	$navPrev = $('<li class="stNavPrevArrow ui-state-active" title="Previous"><span class="ui-icon ui-icon-seek-prev">Previous tab</span></li>'),
					$navNext = $('<li class="stNavNextArrow ui-state-active" title="Next"><span class="ui-icon ui-icon-seek-next">Next tab</span></li>'),
					$navFirst = o.showFirstLastArrows ? $('<li class="stNavFirstArrow ui-state-active" title="First"><span class="ui-icon ui-icon-seek-first">First tab</span></li>') : $(),
					$navLast =  o.showFirstLastArrows ? $('<li class="stNavLastArrow ui-state-active" title="Last"><span class="ui-icon ui-icon-seek-end">Last tab</span></li>') : $();
				//Append elements to the container
				$arrowsNav.append($navPrev,$navFirst,$navLast,$navNext);
				var	$navLis = $arrowsNav.find('li').hover(function(){ $(this).toggleClass('ui-state-active').toggleClass('ui-state-hover'); });
			}
        this.addtab = function() {
            //Update li list
            $lis = $ul.find('li');
            var $thisLi = $lis.filter('li:not(.stHasCloseBtn)');
            //Adjust the position of last tab
            //Welcome the new tab by adding a close button
            _addclosebutton($thisLi);
            //Next move tab to the end
            //See if nav needed
            _showNavsIfNeeded();
            //Adjust the left position of all tabs
            _adjustLeftPosition($thisLi);
            //Check if select on add
            if (o.selectTabOnAdd) {
                $(this).tabs({active:$lis.index($thisLi)});
            }
        };
        this.removeTab = function(id) {
            $ul.find('li:has(a[href="#' + id +'"])').remove();
			$("#tabs #" + id).remove();
			$tabs.tabs("refresh");
			$lis = $ul.find('li');
	        //To make sure to hide navigations if not needed
	        _showNavsIfNeeded();
	        //Adjust the position of tabs, i.e move the Next tabs to the left
	        _adjustLeftPosition();
        };
        
        this.refreshNavBar = function() {
             _showNavsIfNeeded();
        }
        $(window).bind('resize', function() {
            _showNavsIfNeeded();
        });
			//Navigation

		
		function _init()
		{
			//Set the height of the UL and make the LIs as absolute
			$ul.height($lis.first().outerHeight())
			
			//Add navigation buttons
			$ul.after($arrowsNav.css('visibility', o.showNavWhenNeeded ? 'hidden' : 'visible'));
			
			//Adjust arrow position
			if($navLis)
			{
				$navLis.css({
					'top' : '-'+$ul.innerHeight()+'px',
					'height' : $ul.innerHeight()
				});
				
				//Decide which navs in each pair will have to moved inside next to each other
				if(o.nextPrevOutward)
				{
					$navPrev.addClass('ui-corner-left');
					$navNext.addClass('ui-corner-right');
					$navFirst.css( 'margin-left', $arrowsNav.find('li:first').outerWidth() );
					$navLast.css( 'margin-right', $arrowsNav.find('li:first').outerWidth() );
				}
				else
				{
					$navFirst.addClass('ui-corner-left');
					$navLast.addClass('ui-corner-right');
					//If we have first and last arrows to show than move the arrows inward otherwise add the css classes to make their corners round.
					o.showFirstLastArrows ? $navPrev.css( 'margin-left', $arrowsNav.find('li:first').outerWidth() ) : $navPrev.addClass('ui-corner-left');
					o.showFirstLastArrows ? $navNext.css( 'margin-right', $arrowsNav.find('li:first').outerWidth()) : $navNext.addClass('ui-corner-right');
				}
			}
			//Add close buttons if required
			_addclosebutton();
			//See if nav needed
			_showNavsIfNeeded();
			//Adjust the left position of all tabs
			_adjustLeftPosition();
			//Add events to the navigation buttons
			_addNavEvents();
			//If tab is selected manually by user than also change the css class
			$tabs.bind( "tabsactivate", function(event, ui) {
			    var currentTab = $(ui.newTab);
			    var a = currentTab.find('a');
			    var id = a.attr('id');
			    var query = 'a[id=' + id + ']';
			    if($lis.find(query).length ==0) return;
			    if($.isFunction(o.onTabActive)){
			        o.onTabActive({tabid:a.attr('href')});
			    }
				_updateCurrentTab(currentTab);
				//Scroll if needed
				if( _isHiddenOn('n') )
				{
					_animateTabTo('n', null, null, event)
				}
				else if( _isHiddenOn('p') )
				{
					_animateTabTo('p', null, null, event)
				}
				//else do nothing, tab is visible so no need to scroll tab
			})
		}
		
		//Check if navigation need than show otherwise hide it
		function _showNavsIfNeeded()
		{
			if(!o.showNavWhenNeeded)
			{
				return; //do nothing
			}
			//Get the width of all tabs and compare it with the width of $ul (container)
			if(_liWidth() > $ul.width())
			{
				$arrowsNav.css('visibility','visible').show();
			}
			else
			{
				$arrowsNav.css('visibility','hidden').hide();
				//And navigate the tabs to the first
//				_animateTabTo('f', $lis.first(), 0);
			}
		}
		
		function _callBackFnc(fName,event,arg1)
		{
			if($.isFunction(fName))
			{
				fName(event,arg1);
			}
		}
		
		function _isHiddenOn(side, $tab)
		{
			//If no tab is provided than take the current
			$tab = $tab || $curSelectedTab;
			if(side=='n')
			{
				var rightPos = $tab[0].offsetLeft + $tab.width()+5;
				return (rightPos  >  ( $ul.width() - _getNavPairWidth()));
			}
			else//side='p'
			{
				var leftPos = ($tab[0].offsetLeft - _getNavPairWidth());
				return (leftPos < 0 )
			}
		}
				
		function _pullMargin($tab)
		{
			return '-' + (_liWidth($tab) - $ul.width() + _getNavPairWidth()) + 'px';
		}
		
		function _pushMargin($tab)
		{
			var leftPos = ($tab[0].offsetLeft - _getNavPairWidth());
			return (  parseFloat( $tab.css('margin-left') )  - leftPos )  +'px';
		}

		function _animateTabTo(side, $tab, tabIndex, e)
		{
			$tab = $tab || $curSelectedTab;
			var margin = 0;
			if(side=='n')
			{
				margin = _pullMargin($tab);
			}
			else if(side=='p')
			{
				margin = _pushMargin($tab);
			}
			else if(side=='f')
			{
				margin = 0;
				tabIndex = 0;
			}
			else if(side=='l')
			{
				margin = _pullMargin($tab);
			}
			//d($tab);
			
			$lis
				//.stop(false, true) //.stop( [ clearQueue ], [ jumpToEnd ] ) - this line is not working properly 
				.animate({'margin-left' : margin }, o.scrollSpeed,o.easing);
			
			if(o.selectTabAfterScroll && tabIndex!==null)
			{
				$tabs.tabs({active:tabIndex});
			}
			else
			{
				//Update current tab
				if(tabIndex>-1) //Means this method is called from showTab event so tab css is already updated
				{
					//d($tab);
					_updateCurrentTab($tab);
					//d($curSelectedTab);
				}
			}
			
			//Callback
			e = (typeof e=='undefined') ? null : e;
			_callBackFnc(o.onTabScroll,e,$tab)
			
			//Finally stop the event
			if(e){
				e.preventDefault();
			}
		}
		
		function _addCustomerSelToCollection(col,nav)
		{
			var sel = o['customNav'+nav] || '';
			//Check for custom selector
			if(typeof sel=='string' && $.trim(sel)!='')
			{
				col = col.add(sel);
			}
			return col;
		}
		
		function _addNavEvents()
		{
			$navNext = $navNext ? $navNext : $();
			$navNext = _addCustomerSelToCollection($navNext,'Next');

			//Handle next tab
			$navNext.click(function(e){
				var $nxtLi = $();
				//First check if user do not want to select tab on Next than we have to find the next hidden (out of viewport) tab so we can scroll to it
				if(!o.selectTabAfterScroll)
				{
					$curSelectedTab.nextAll('li').each(function(){
						//d($(this));
						//d(_isHiddenOn('n', $(this)));
						if(_isHiddenOn('n', $(this)))
						{
							$nxtLi = $(this);
							return false;
						}
					});
				}
				else
				{
					$nxtLi = $curSelectedTab.next('li');
				}
				//return;
				
				//check if there is no next tab
				if(!$nxtLi.length)
				{
					//d('You are on last tab, no next tab found.');
					return false;
				}
				
				//check if li next to selected is in view or not
				var isTabHidden = _isHiddenOn('n', $nxtLi);
				
				//get index of next element
				indexNextTab = $lis.index( $nxtLi );

				if(isTabHidden)
				{
					_animateTabTo('n', $nxtLi, indexNextTab, e);
				}
				else
				{
					$tabs.tabs({active:indexNextTab});
				}
			})
			
			
			//Handle previous tab
			$navPrev = $navPrev ? $navPrev : $();
			$navPrev = _addCustomerSelToCollection($navPrev,'Prev');
			
			$navPrev.click(function(e){
				var $prvLi = $();
				
				//First check if user do not want to select tab on Prev than we have to find the prev hidden (out of viewport) tab so we can scroll to it
				if(!o.selectTabAfterScroll)
				{
					//Reverse the order of tabs list
					$($lis.get().reverse()).each(function(){
						if(_isHiddenOn('p', $(this)))
						{
							$prvLi = $(this);
							return false;
						}
					});
				}
				else
				{
					$prvLi = $curSelectedTab.prev('li');
				}
				//return; 
					
				if(!$prvLi.length)
				{
					//d('There is no previous tab. NO PREV TAB');
					return false;
				}

				//check if li previous to selected is in view or not
				var isTabHidden = _isHiddenOn('p', $prvLi);
				
				//Get index of prev element
				var indexPrevTab = $lis.index( $prvLi );
					
				if(isTabHidden)
				{
					_animateTabTo('p', $prvLi, indexPrevTab, e);
				}
				else
				{		
					$tabs.tabs({active:indexPrevTab});
				}
				return false;
			});
			
			//Handle First tab
			$navFirst = $navFirst ? $navFirst : $();
			$navFirst = _addCustomerSelToCollection($navFirst,'First');	
			$navFirst.click(function(e) {
				//check if li selected is the first tab already
				if($lis.index($curSelectedTab)==0)
				{
					//console.log('You are on first tab already');
					return false;
				}
				_animateTabTo('f', $lis.first(), 0, e);
				return false;
			});
			
			//Handle last tab
			$navLast = $navLast ? $navLast : $();
			$navLast = _addCustomerSelToCollection($navLast,'Last');
			
			$navLast.click(function(e) {	
				//check if there is no next tab
				var $lstLi = $curSelectedTab.next('li');
				if(!$lstLi.length)
				{
					//d('You are already on the last tab. there is no more last tab.');
					return false;
				}
				//Get index of prev element
				var indexLastTab = $tabs.find('ul li').length-1;
				_animateTabTo('l', $lis.last(), indexLastTab, e);
				return false;
			});
			
			
		}
		
		function _updateCurrentTab($li)
		{
			//Remove current class from other tabs
			$ul.find('.stCurrentTab').removeClass('stCurrentTab');
			//Add class to the current tab to which it is scrolled and updated the variable
			$curSelectedTab = $li.addClass('stCurrentTab');
		}
		
		
		function _addclosebutton($li)
		{
			if(!o.closable) return;
			//If li is provide than just add to that, otherwise add to all
			var lis = $li || $lis;
			lis.each(function(){
				
				var $thisLi = $(this).addClass('stHasCloseBtn');
				$(this)
				.append(
					$('<span/>')
						.addClass('ui-state-default ui-corner-all stCloseBtn')
						.hover(function(){ $(this).toggleClass('ui-state-hover') })
						.append(
							$('<span/>')
								.addClass('ui-icon ui-icon-circle-close')
								.html('Close')
								.attr('title','Close this tab')
								.click(function(e){
								    var id = $thisLi.find('a').attr('href');
								     $thisLi.remove();
								     $("#tabs " + id).remove();
								    $tabs.tabs("refresh");
								     $lis = $ul.find('li');
	                                //To make sure to hide navigations if not needed
	                                _showNavsIfNeeded();
	                                //And navigate the tabs to the first	Jimmy modify	    
                                    _animateTabTo('f', $lis.first(), 0);
	                                //Adjust the position of tabs, i.e move the Next tabs to the left
	                                _adjustLeftPosition();
								})
							)
				)
				//If width not assigned, the hidden tabs width cannot be calculated properly in _adjustLeftPosition
				.width($thisLi.outerWidth())
			});
		}
		
		function _getNavPairWidth(single)
		{
			//Check if its visible
			if($arrowsNav.css('visibility')=='hidden')
			{
				return 0;
			}
			//If no nav than width is zero - take any of the nav say prev and multiply it with 2 IF we first/last nav are shown else with just 1 (its own width)
			var w = o.hideDefaultArrows ? 0 : $navPrev.width() * (o.showFirstLastArrows ? 2 : 1 );
			return single ? w/2 : w;
		}
		
		function _adjustLeftPosition($li)
		{
			//If li is provided, find the left and width of second last (last is the new tab) tab and assign it to the new tab
			if($li)
			{
				if($lis.lenght==1) return;
				var $thisPrev = $li.prev('li') || $lis.first(),
					newLeft = parseFloat($thisPrev.css('left'));
					//d(newLeft);
					newLeft = isNaN(newLeft) ? 0 : newLeft;
					newLeft = newLeft + $thisPrev.width()+4;
					//Assign
					$li.css({
						'left':newLeft,
						'margin-left': $thisPrev.css('margin-left') 
					});
				return;
			}
			
			//Add css class n take its left value to start the total width of tabs
			var pairWidth = _getNavPairWidth(),
				leftPush = pairWidth==0 ? 3 : pairWidth + 2;
			$lis.first().addClass('stFirstTab').css({'left': leftPush, 'margin-left':0});
			
			var tw = leftPush ;
			
			//Take left margin if any
			var leftMargin = parseFloat($lis.last().prev('li').css('margin-left'));
			
			$ul.find('li:not(:first)').each(function(){
				//Apply the css
				$(this).css('margin-left',0)[o.animateTabs ? 'animate' : 'css']({'left': tw += $(this).prev('li').width() })
				//d($(this));
			});
			
			$lis.css('margin-left',leftMargin);
		}
		

		function _liWidth($tab)
		{
			var w=0,
			list = $tab ? $tab.prevAll('li').andSelf() : $lis;
			list.each(function(){
				w+=$(this).width() + parseInt($(this).css('margin-right'),10); //not outerWidth(true) because margin-left is changed in previous call so better take right margin which doesn't change in this plugin
			});
			
			var navWidth = $arrowsNav.css('visibility')=='visible' ? _getNavPairWidth() : 0;
			//d(navWidth);
			return w + navWidth;
		}
		
		_init();
	});
}
})(jQuery)


/* 
1. This does not work properly Sean/Oliver.
   It works fine when it starts the plugin but when you try any of the .tabs method like $tabs.tabs('add',index), it re-apply the plugin to the tabs everytime
2. Also, can this be moved to the plugin?
*/

/*try{
    jQuery._old_tabify = jQuery.ui.tabs.prototype._tabify;
    jQuery.ui.tabs.prototype._tabify = function (init)
	{
        $._old_tabify.apply(this,[init]);
        if(this.options.scrollable)
		{
            this.element.scrollabletabs(this.options.scrollable);
        }
    }
}
catch(e)
{
    alert('jQuery scrollable plugins requires jQuery UI tabs which is either\n1. Not included\n2. Included after the plugin file.\n\n'+e);
}
*/