var canvas;
var ctxl;

window.onload = init()

function init() {
	canvas = document.getElementById('canvas');
	ctx = canvas.getContext("2d");
	//Render a circle
	ctx.arc(100, 200, 50, 0, 2 * Math.PI, false);
	ctx.fillStyle = 'Navy';
	ctx.fill();
};