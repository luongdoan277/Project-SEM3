const filmTime = document.querySelectorAll('.film-time');


filmTime.forEach(film =>{
  film.addEventListener('click',function(){
    filmTime.forEach(film =>{
      film.classList.remove('active-films');
    })
    film.classList.add('active-films');
  });
});