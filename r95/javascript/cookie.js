/* $Id: cookie.js 57 2005-11-10 04:02:31Z khtan $
 
*/
if(navigator.cookieEnabled){

   // Release version
   function cookieExists(cookieName){
     // adapted from Javascript - the Definitive Guide pp272
      var allCookies=document.cookie;
      if(allCookies=="") return false;
      var start=allCookies.indexOf(cookieName);
      if(-1==start) return false;
      return true;    
   }

   var debugWin;
   function debugOutput(a,b){}
   /*
   // Debug version
   function cookieExists(cookieName){
     // adapted from Javascript - the Definitive Guide pp272
      var allCookies=document.cookie;
      if(allCookies==""){ 
        debugOutput(debugWin,"false : cookieExists - no cookies exist");
        return false;
      }
      var start=allCookies.indexOf(cookieName);
      if(-1==start){
         debugOutput(debugWin,"false : cookieExists - "+cookieName +" cookie not found");
         return false;
      }
      // this section is not really needed for existence check
      //    but it is useful to read the value of the cookie
      //    so the return is placed after this code segment
      start+=cookieName.length+1;
      var end=allCookies.indexOf(';',start);
      if(-1==end) end=allCookies.length;
      var cookieValue=unescape(allCookies.substring(start,end));
      debugOutput(debugWin,"true : cookieExists - "+cookieName+" has value "+cookieValue);
      return true;    
   }// cookieExists
   */
   function createCookie(cookieName,cookieValue,minsToExpire,path,domain,secure){
   /* Paramter minsToExpire instead of hrsToExpire for easy testing
    */
     var cookieString=cookieName+"="+escape(cookieValue);
     if(minsToExpire){
       var expireDate=new Date((new Date()).getTime()+minsToExpire*60*1000); // 60s in min x 1000 millisecs
       cookieString+="; expires="+expireDate.toGMTString();
     }
     if(path){
       cookieString+="; path="+path;
     }
     if(domain){
       cookieString+="; domain="+domain;
     }
     if(secure){
       cookieString+="; secure="+secure;
     }
     debugOutput(debugWin,"cookieString="+cookieString);
     document.cookie=cookieString;
   }//createCookie
   function deleteCookie(cookieName){
       if(cookieExists(cookieName)){
          createCookie(cookieName,"",-5,"","");
       }
       debugOutput(debugWin,"Check cookie again");
       cookieExists(cookieName);
   }//
   function loginDeflect(){
   // Check for login, else deflect user to default.htm
       if(!cookieExists("KHT_IsLoggedIn")) location.href="default.htm";
   }//loginDeflect
}else{
  alert("Warning: some functionality is not enabled because cookie is disabled!");
}
