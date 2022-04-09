<!DOCTYPE html>
<html lang="es">
   <head>
      <meta charset="UTF-8">
      <meta name="viewport" content="width=device-width, initial-scale=1.0">
      <link rel="shortcut icon" type="image/png" href="favicon.png"/>
      <title>operadores</title>
      <link rel="stylesheet" href="styles.css">
   </head>
   <body>
      <header>
         <section class="header">
            <nav>
               <ul>
                  <li class="nav_title"><a href="./">operadores</a></li>
               </ul>
            </nav>
         </section>
      </header>
      <section class="contenido">
         <h1 class="title">operadores</h1>
         <span>Crear un algoritmo ejemplo diferente a lo que se vio en clase utilizando un array</span>
         <span>Al ingresar un numero del 1 al 5 se diga un animal</span>
         <!-- Ejercicio 1 -->
         <div class="ejercicio">
            <form class="int" method="post" action="">
               <label>Ingrese un numero del 0 al 4</label>
               <input type="text" name="numero" placeholder="0" required />
               <!-- Código PHP -->
               <?php
                  //Variables
                  $numero    = filter_input(INPUT_POST,'numero'); 

                  $animales = array("perro", "gato", "loro", "pez", "hamster");
                  
                  if (isset($_POST['resultado'])){
                     echo '<h4 class="result">Resultado</h4>
                     <div class="respuesta">
                        <ul class="resultado">
                           El animal escogido es  '.$animales[$numero] .';
                        </ul>   
                     </div>';
                  }
                  ?>
               <input class="button" type="submit" name="resultado" value="calcular">
            </form>
         </div>
         <div class="returns">«<a href="./">Regresar</a></div>
      </section>
      <footer class="footer">
         <div class="autor">estudiante</div>
      </footer>
   </body>
</html>