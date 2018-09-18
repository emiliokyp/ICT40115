const c = document.getElementById('clock');
const el_img = document.getElementById('img');
const ctx = c.getContext('2d');


const renderHours = date => {
    const hours = (date.getHours() + (date.getMinutes() / 60) ) % 12;
    draw(radians((hours*30) - 90), 150);
}

const renderMinutes = date => {
    const minutes = date.getMinutes() + (date.getSeconds() / 60);
    draw(radians((minutes*6) - 90), 125);
}

const renderSeconds = date => {
    const seconds = date.getSeconds() + (date.getMilliseconds() / 1000);
    draw(radians((seconds*6) - 90), 100);
}

const render = () => {

    ctx.clearRect(0, 0, c.width, c.height);
    let date = new Date();
    renderHours(date);
    renderMinutes(date);
    renderSeconds(date);
}

renderImage = () => {
    return fetch('https://api.thecatapi.com/v1/images/search')
    .then((res) => res.json())
    .then((res) => {
        el_img.src = res[0].url;
    });
}

const draw = (angle, radius) => {
     ctx.beginPath();
     ctx.lineWidth=3;
     ctx.arc(c.width/2, c.height/2, radius, 1.5*Math.PI, angle, false);
     ctx.stroke();
     ctx.closePath();
}

const radians = angle => (angle * (Math.PI / 180));


renderImage().then(() => setInterval(renderImage, 5000));
setInterval(render, 1000/60);