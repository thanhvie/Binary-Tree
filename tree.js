var arrayNumber = [];
function Tree(){

  this.root = null;

  //run function visit recursively to print out values from smallest to highest
  this.traverse = function(){
    this.root.visit(this);
  }

  //run search function recursively
  this.search = function(val){
    var found = this.root.search(val);
    return found;
  }

  //add note for the tree
  this.addValue = function(val){
    arrayNumber.push(val);
    var n = new Node(val);
    if(this.root == null){
      this.root = n;
      this.root.x = width/2;
      this.root.y = 32;
    }else{
        this.root.addNote(n);
    }

  }
}
