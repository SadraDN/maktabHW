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
  option.value= color
  getEl.add(option); 
}

for (i=0 ; i<data.length ; i++)
{
  let color= data[i]
  addoption(color);
}

// document.getElementById('color-select').addEventListener('change' , boxcolorchange)

onclick= boxcolorchange;

function boxcolorchange()
{
var selectBox = document.getElementById("color-select").value;
var boxcolor = document.getElementById("box");


if (selectBox == 'Teal')
{
  boxcolor.style.backgroundColor = 'Teal';
  setTimeout(function () { boxcolor.style.backgroundColor = 'silver' }, 1000);
}
if (selectBox == 'SkyBlue')
{
  boxcolor.style.backgroundColor = 'SkyBlue';
  setTimeout(function () { boxcolor.style.backgroundColor = 'silver' }, 1000);
}
if (selectBox == 'DarkSeaGreen')
{
  boxcolor.style.backgroundColor = 'DarkSeaGreen';
  setTimeout(function () { boxcolor.style.backgroundColor = 'silver' }, 1000);
}
if (selectBox == 'Purple')
{
  boxcolor.style.backgroundColor = 'Purple';
  setTimeout(function () { boxcolor.style.backgroundColor = 'silver' }, 1000);
}
if (selectBox == 'LightPink')
{
  boxcolor.style.backgroundColor = 'LightPink';
  setTimeout(function () { boxcolor.style.backgroundColor = 'silver' }, 1000);
}
if (selectBox == 'Crimson')
{
  boxcolor.style.backgroundColor = 'Crimson';
  setTimeout(function () { boxcolor.style.backgroundColor = 'silver' }, 1000);
}
}

