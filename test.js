const add = (a, b) => {
  return a + b;
};
console.log(add(4, 1));

let z = 9001;
z = 8999;
function overNineThousand() {
  if (z > 9000) {
    return "OVER 9000!!!!";
  } else if (z < 9000) {
    return "Git good son!";
  } else {
    console.log("not a valid input");
  }
}
console.log(overNineThousand());
