// Stat counter animation
document.querySelectorAll('.stat-number[data-target]').forEach(function(el) {
    var target = parseInt(el.getAttribute('data-target'), 10);
    var current = 0;
    var step = Math.ceil(target / 50);
    var timer = setInterval(function() {
        current += step;
        if (current >= target) {
            el.textContent = target;
            clearInterval(timer);
        } else {
            el.textContent = current;
        }
    }, 20);
});

// Mobile hamburger
var hamburger = document.getElementById('hamburger');
var navLinks = document.getElementById('navLinks');
if (hamburger && navLinks) {
    hamburger.addEventListener('click', function() {
        navLinks.classList.toggle('open');
    });
}
