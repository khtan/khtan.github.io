/* $Id: debug.js 74 2005-11-16 00:49:17Z khtan $
Create a debug window to keep all the debug outputs
   Todo:
   1) Turn function to empty for release. But function call still incurred.
   2) 

debugOutput(validateEmail.toString()); returns the entire function, name and contents
IE6.0 does not like global variables like declaring dWin in file scope. It will fail.
This is probably a good thing, since globals can cause other problems.
*/
function openDebug(msg){
   var dWin=window.open("","debugWindow",'scrollbars,status,resizable,toolbar,width=400,height=350');
   dWin.document.write("<h2>Debug : "+msg+"</h2>");
   return dWin;
}
function debugOutput(dWin,msg){
   if(dWin){
      dWin.document.write(msg+"<br>");
   }
}
function debugOutput1(dWin,msg){
   if(dWin){
      dWin.document.write("<pre>");
      dWin.document.write(msg);
      dWin.document.write("</pre>");
   }
}
function walkChildNodes(objRef, n) {
/* Adapted from Javascript & DHTML Cookbook, 
   14.17 "Walking the Document Node Tree"
*/
    var obj;
    if (objRef) {
        if (typeof objRef == "string") {
            obj = document.getElementById(objRef);
        } else {
            obj = objRef;
        }
    } else {
        obj = (document.body.parentElement) ? 
            document.body.parentElement : document.body.parentNode;
    }
    var output = "";
    var indent = "";
    var i, group, txt;
    if (n) {
        for (i = 0; i < n; i++) {
            indent += "+---";
        }
    } else {
        n = 0;
        output += "Child Nodes of &lt;" + obj.tagName .toLowerCase();
//        output += "Child Nodes of <" + obj.tagName .toLowerCase();
        output += "&gt;\n=====================\n";
//        output += ">\n=====================\n";
    }
    group = obj.childNodes;
    for (i = 0; i < group.length; i++) {
        output += indent;
        switch (group[i].nodeType) {
            case 1:
                output += "&lt;" + group[i].tagName.toLowerCase();
//                output += "<" + group[i].tagName.toLowerCase();
                output += (group[i].id) ? " ID=" + group[i].id : "";
                output += (group[i].name) ? " NAME=" + group[i].name : "";
                output += "&gt;\n";
//                output += ">\n";
                break;
            case 3:
                txt = group[i].nodeValue.substr(0,30);
                output += "[Text:\"" + txt.replace(/[\r\n]/g,"&lt;cr&gt;");
                if (group[i].nodeValue.length > 30) {
                    output += "...";
                }
                output += "\"]\n";
                break;
            case 8:
                output += "[!COMMENT!]\n";
                break;
            default:
                output += "[Node Type = " + group[i].nodeType + "]\n";
        }
        if (group[i].childNodes.length > 0) {
            output += walkChildNodes(group[i], n+1);
        }
    }
    return output;
}


