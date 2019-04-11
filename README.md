# Scripting_201910_Parcial2_Base

Edite este archivo para responder el último enunciado del examen. No cree otro archivo.


  Juan Camilo Rodriguez Solano
  000335772


Los patrones utilizados

Singleton: Era perfecto para utilizarlo como el instanciador de los enemigos, ya que este debia de volver a spawnear enemigos cuando ya todos estuviesen destruidos. Por lo tanto necesitabamos de una unica instancia a la cual todos los enemigos pudieran mandar informacion cuando fuesen derrotados, y esta se aseguraria de respawnearlos luego. Pero esto podria fallar si hubiesen multiples instancias que recibieran informacion de la manera en como se escribio ese codigo.

Pool: Ya que nos pedian no destruir y recrear balas/enemigos, el pool fue utilizado para (en vez de destruirlos, mantenerlos desactivados) hacer el management de las balas y los enemigos, de manera que fuesen re-utilizables.
State: Teoricamente se implementa state ya que queremos que hayan diferentes comportamientos de acuerdo a ciertos factores que ocurren en el juego: Este caso la distancia del jugador.

Algunos no usados:

Factory: Ya que el juego es muy sencillo y en realidad no necesitamos ninguna dependencia del otros factores, ya que no es algo al estilo proceudal (Tenemos un numero fijo de balas y enemigos en este caso) decidi no utilizarlo.

Decorador: No habia ningun tipo de upgrade o algo parecido, asi que no habia necesidad de agregar o quitar funcionalidades de esta manera.

Flyweight: No tenemos muchas instancias de la misma clase, asi que no es necesario utilizarlo en un proyecyo de estos.


Informacion Adicional:

Efectivamente no se que hice
Me toste demasiado asi que queria hacerlo funcionar de una manera u otra

-Por cierto no entiendo por que las balas del enemigo se apagan instantaneamente.

RIP

