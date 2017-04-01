var sortedArray = [];
function Node(val, x, y){
  this.value = val;
  this.left = null;
  this.right = null;
  this.x = x;
  this.y = y;

  this.visit = function(parent){
    //console.log(this.value);
    if(this.left != null)
    {
      this.left.visit(this);
    }
    //console.log(this.value);
    sortedArray.push(this.value);
    if(this.right != null)
    {
      this.right.visit(this);
    }
    stroke(255);
    line(parent.x, parent.y, this.x, this.y);

    fill(0,139,139);
    ellipse(this.x, this.y, 40, 40);

    noStroke();
    textAlign(CENTER);
    fill(255);
    text(this.value, this.x, this.y);
    stroke(255);


  }

  this.search = function(val){
    if(this.value == val){
      return this;
      console.log("found " + val);
    }

    else if(val < this.value && this.left != null)
    {
      return this.left.search(val);
    }

    else if(val > this.value && this.left != null)
    {
      return this.right.search(val);
    }
  }

  this.addNote = function(n){
    if(n.value <this.value)
    {
      if(this.left == null)
      {

        this.left = n;
        this.left.x = this.x - 100;
        this.left.y = this.y + 40;
      }

      else {
        this.left.addNote(n);
      }
    }

    else if(n.value > this.value) {
      if(this.right == null)
      {
        this.right = n;
        this.right.x = this.x + 100;
        this.right.y = this.y + 40;
      }
      else {
        this.right.addNote(n);
      }
    }
  }
}
