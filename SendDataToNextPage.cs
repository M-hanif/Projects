protected viod page_load(object sender, eventargs e){

Webform1 previousePage= (WebForm1)this.PreviousePage;
if(previousePage != null && previousePage.IsCrossPagePostBack){
lblname.text=previousePage.name;
lblEmail.text=previousePage.email;
}
}
