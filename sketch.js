var button;
var arr1;
var arr2;
var str1 = '';
var str2 = '';

function setup() {
  createCanvas(800,400);
  background(51);
  createP('');
  button = createButton('Create binary tree');
  button.mousePressed(changeTree);
  arr1 = createP(str1);
  arr2 = createP(str2);
}

function changeTree(){
  arrayNumber.splice(0, arrayNumber.length);
  sortedArray.splice(0, sortedArray.length);
  background(51);
  var tree = new Tree();

  //add 5 note to the tree
  for(var i = 0; i < 5; i++){
    tree.addValue(floor(random(0,100)));
  }

  //re-order the note values from smallest to highest
 tree.traverse();
 str1 = 'list of Node: ' + arrayNumber;
 str2 = 'list of Node after sorting: ' + sortedArray;
 arr1.html(str1);
 arr2.html(str2);
}
