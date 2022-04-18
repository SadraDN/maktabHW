const data = [
  'Teal',
  'SkyBlue',
  'DarkSeaGreen',
  'Purple',
  'LightPink',
  'Crimson'
];
const defaultColor = 'Silver';

function addoption(color)
{
  var getEl = document.getElementById('color-select');
  var option = document.createElement('option');
  option.text= color;
  option.value= color;
  getEl.add(option); 
}

for (i=0 ; i<data.length ; i++)
{
  let color= data[i]
  addoption(color);
}

function boxcolorchange()
{
var selectBox = document.getElementById("color-select").value;
var boxcolor = document.getElementById("box");
boxcolor.style.backgroundColor = selectBox;
setTimeout(() => {
  boxcolor.style.backgroundColor = defaultColor;
}, 1000);
}

addEventListener('change',boxcolorchange);

  



