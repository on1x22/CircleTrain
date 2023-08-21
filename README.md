# CircleTrain
Test case for VDcom  

### Задача:
Поезд замкнутый (каждый вагон сцеплен с двумя другими). Можно представлять, что он стоит на 
замкнутых круглых путях. В начальный момент времени наблюдатель (тот, кто считает вагоны) 
находится перед одним из вагонов (неизвестно каким). В каждый момент времени наблюдатель видит 
только один вагон. Наблюдатель может двигаться вдоль поезда и включать/выключать свет в вагонах. 
Все вагоны одинаковые. Изначально свет в каждом конкретном вагоне может гореть, а может и не 
гореть – это заранее неизвестно.

### Нужно: 
1.	Посчитать количество вагонов в поезде.
2.	Написать программку на C#, реализующую данную логику. Необходимо использовать ООП.

### Алгоритм
Наблюдатель входит в первый вагон и включает в нём свет, если тот отключен, и переходит в 
следующий вагон, запоминая количество пройденных вагонов. Во всех последующих вагонах если 
свет отключен, то наблюдатель двигается дальше, также считая количество пройденных вагонов, 
а если включен, то отключает в нём свет и возвращается на посчитанное количество вагонов назад 
(к первому вагону). Если в первом вагоне свет отключен, то наблюдатель прошёл по всем вагонам 
поезда, а посчитанное число и есть количество вагонов в поезде. Если в первом вагоне свет 
включен, наблюдатель идет дальше, повторяя описанный выше алгоритм.

### Комментарий
При инициализации поезда (Train) создается произвольное количество вагонов (Carriage) в диапазоне от 0 до 19.
