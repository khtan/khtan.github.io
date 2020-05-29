/* $Id: graph.js,v 1.5 2008/08/28 21:17:36 khtan Exp $ 
Purpose:
*/
function initGW(file,name){
    var dWin=window.open(file,name,'scrollbars,status,resizable,toolbar,width=420,height=360');
    return dWin;
}
function scrollGW(dWin,file,msg,x,y){
    if( typeof(dWin) == 'undefined' || dWin.closed ) {
        dWin=initGW(file,msg);
    }
    if(dWin){
        dWin.scroll(x,y);
        dWin.focus();
    }
    return dWin;
}
