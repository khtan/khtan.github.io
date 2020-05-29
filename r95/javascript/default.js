      /* $Id: default.js 90 2005-11-24 00:25:05Z khtan $ */
      /* alert("Hello world - internal");*/
      function getBrowserAndVersion(){
         // Detects IE, Netscape and Opera.
         //   For Opera, also show which browser it is emulating
         //   IE and Netscape version detection adapted from Javascript & DHTML Cookbook
         var aN=navigator.appName;
         var uA=navigator.userAgent;
         var oIndex=uA.indexOf("Opera");
         var splitSeparator="/";
         if(aN=="Microsoft Internet Explorer"){ // Opera or IE
            if(oIndex<0){ // IE
               var msOffset=uA.indexOf("MSIE ");
               var msVer=uA.substring(msOffset+5,uA.indexOf(";",msOffset))
               return "Internet Explorer"+splitSeparator+msVer;
            }else{ // Opera as IE
              return uA.substring(oIndex)+" as IE";
            }
         }else if(aN=="Netscape"){ // Opera or Netscape
           if(oIndex<0){ // Netscape
              return "Netscape"+splitSeparator+navigator.appVersion;
           }else{ // Opera as Netscape
              return uA.substring(oIndex)+" as Netscape";
           }
         }else if(oIndex==0){ // Opera
            var spaceOffset=uA.indexOf(" ");
            // splitSeparator / already in uA
            return uA.substring(0,spaceOffset);
         }else{
           return aN+splitSeparator+navigator.appVersion;
         }
      }//getBrowserAndVersion
      function getAdjustedLength(str){
         // When setting size of textbox to length of value, IE browser sometimes over calculates and leaves spaces
         // This function is a quick hack to exclude thin characters so that the length returned is better utilized by textbox size.
         // See DHTML book page pp761 input(type="text")
         //    Reduce the length of str by number of thin characters, such as .,: and i
         var len=str.length;
         var lcstr=str.toLowerCase();
         var adjust=0;
         var charTarget;
         for(var i=0;i<len;++i){
            charTarget=lcstr.charAt(i);
            if(charTarget=="." || charTarget==":" || charTarget=="i" || charTarget=="1" || charTarget=="l" || charTarget=="/"){
               adjust++;
            }
         }
         // debugOutput(debugWin,"str="+str);
         // debugOutput(debugWin,"len="+len+" adjust="+adjust);
         return len-adjust;
      }
      function getAllSheets(){
         /* This function is adapted from http://www.howtocreate.co.uk/jslibs/htmlhigh/swapstyle.html
            The .ScriptEngine check is erroneous and removed, because IE6 supports document.styleSheets, yet
            the check causes it to skip to next section.
            This implementation requires the use of linked css, not imported css.  
         */
         if(document.styleSheets){ // use document.styleSheets if available, IE6
            // debugOutput(debugWin,"css in document.styleSheets");
            return document.styleSheets;
         }
         // Create an array of linked stylesheets for browsers that don't support document.styleSheets like Opera8
         if( document.getElementsByTagName ) { 
            var Lt = document.getElementsByTagName('link'), St = document.getElementsByTagName('style');
         } else if( document.styleSheets && document.all ) { 
            var Lt = document.all.tags('LINK'), St = document.all.tags('STYLE');
         } else { 
            return []; 
         } 
         for( var x = 0, os = []; Lt[x]; x++ ) {
            var rel = Lt[x].rel ? Lt[x].rel : Lt[x].getAttribute ? Lt[x].getAttribute('rel') : '';
            if( typeof( rel ) == 'string' && rel.toLowerCase().indexOf('style') + 1 ) { 
               os[os.length] = Lt[x]; 
            }
         } 
         for( var x = 0; St[x]; x++ ) { 
            os[os.length] = St[x]; 
         }
         // debugOutput(debugWin,"css in os array");
         return os;
      }//getAllSheets
      function changeStyle(cssFile){
         /* This function is adapted from http://www.howtocreate.co.uk/jslibs/htmlhigh/swapstyle.html
            Instead of looking for title, my requirements are simpler, just check for the debug.css script
            There is a bug in Opera8 where on page load, the debug.css, although has disabled==true, does
            not display. Hence a call to changeStyle is needed in initPage to toggle once.
         */ 
         var stringValue="";
         var ss=getAllSheets();
         for( var x = 0; x< ss.length; x++ ){
            stringValue=ss[x].href;
            if(stringValue!=null){
               // debugOutput(debugWin,"stringValue="+stringValue);
               if( -1 != stringValue.indexOf(cssFile)){
                  ss[x].disabled= (ss[x].disabled==true)? false:true;
                  break; // no need to search anymore
               }//indexOf
           }//!=null
         }//for
      }//changeStyle
      // ---------------
      // Lab 7 functions
      function openWin(url){
         // opens a window sized 400x400 in the center of user screen
         var winWidth=400;
         var winHeight=400;
         var winTop=(screen.availHeight-winHeight)/2;
         var winLeft=(screen.availWidth-winWidth)/2;
         debugOutput(debugWin,'scrollbars,status,resizable,toolbar,width='+winWidth+',height='+winHeight+',left='+winLeft+',top='+winTop);
         var xWin=window.open(url,"testWindow",'scrollbars,status,resizable,toolbar,width='+winWidth+',height='+winHeight+',left='+winLeft+',top='+winTop);
         return xWin;
      }//openWin
      function openWinName(url,name){
         // opens a window sized 400x400 in the center of user screen
         var winWidth=400;
         var winHeight=400;
         var winTop=(screen.availHeight-winHeight)/2;
         var winLeft=(screen.availWidth-winWidth)/2;
         debugOutput(debugWin,'scrollbars,status,resizable,toolbar,width='+winWidth+',height='+winHeight+',left='+winLeft+',top='+winTop);
         var xWin=window.open(url,name,'scrollbars,status,resizable,toolbar,width='+winWidth+',height='+winHeight+',left='+winLeft+',top='+winTop);
         return xWin;
      }//openWin
      function deleteAllCookies(){
         deleteCookie("KHT_HasBeenSpammed");
         deleteCookie("KHT_IsLoggedIn");
      }//deleteAllCookies
