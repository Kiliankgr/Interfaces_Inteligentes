# Seminario 3 - Mundos virtuales. Introducción a la programación de gráficos 3D.

## Qué funciones se pueden usar en los scripts de Unity para llevar a cabo traslaciones, rotaciones y escalados.
transform.Translate, transform.Rotate, transform.LocalScale.

## Como trasladarías la cámara 2 metros en cada uno de los ejes y luego la rotas 30º alrededor del eje Y?. Rota la cámara alrededor del eje Y 30ª y desplázala 2 metros en cada uno de los ejes. ¿Obtendrías el mismo resultado en ambos casos?. Justifica el resultado
trasform.Translate(new Vector3(2,2,2)); transform.Rotate(0,30.0f,0);
Depende de si los movimiento se producen respecto al objete (Cambiaria el resultado), ya que al rotar los ejes se modifican y al añadirle 2 metros a cada eje se desplazaria en funcion de la posicion de los ejes, por lo tanto si se rotan se moveria en otra direccion. Si es dependiendo del Space.world ( No debería cambiar el resultado). 

## Sitúa la esfera de radio 1 en el campo de visión de la cámara y configura un volumen de vista que la recorte parcialmente.


## Sitúa la esfera de radio 1 en el campo de visión de la cámara y configura el volumen de vista para que la deje fuera de la vista.

## Como puedes aumentar el ángulo de la cámara. Qué efecto tiene disminuir el ángulo de la cámara.

## Es correcta la siguiente afirmación: Para realizar la proyección al espacio 2D, en el inspector de la cámara, cambiaremos el valor de projection, asignándole el valor de orthographic

## Especifica las rotaciones que se han indicado en los ejercicios previos con la utilidad quaternion.

## ¿Como puedes averiguar la matriz de proyección en perspectiva que se ha usado para proyectar la escena al último frame renderizado?.

## ¿Como puedes averiguar la matriz de proyección en perspectiva ortográfica que se ha usado para proyectar la escena al último frame renderizado?.

## ¿Cómo puedes obtener la matriz de transformación entre el sistema de coordenadas local y el mundial?.
La matriz de tranformación se obtiene al buscar la relación de la matriz de cordenadas local con la mundial. (Mas o menos)

## Cómo puedes obtener la matriz para cambiar al sistema de referencia de vista

## Especifica la matriz de la proyección usado en un instante de la ejecución del ejercicio 1 de la práctica 1.

## Especifica la matriz de modelo y vista de la escena del ejercicio 1 de la práctica 1.

## Aplica una rotación en el start de uno de los objetos de la escena y muestra la matriz de cambio al sistema de referencias mundial.

## ¿Como puedes calcular las coordenadas del sistema de referencia de un objeto con las siguientes propiedades del Transform:?: Position (3, 1, 1), Rotation (45, 0, 45)
(creo que con Transform.rigth,Transform.up,Transform.forward)
