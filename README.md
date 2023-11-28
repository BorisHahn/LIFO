## LIFO

### Нужно создать класс Stack у которого будут следующие свойства

* В нем будем хранить строки
* В качестве хранилища используйте список List
* Конструктор стека может принимать неограниченное количество входных параметров типа string, которые по порядку добавляются в стек
* Метод Add(string) - добавить элемент в стек
* Метод Pop() - извлекает верхний элемент и удаляет его из стека. При попытке вызова метода Pop у пустого стека - выбрасывать исключение с сообщением "Стек пустой"
* Свойство Size - количество элементов из Стека
* Свойство Top - значение верхнего элемента из стека. Если стек пустой - возвращать null 

### Доп. задание 1
* Создайте класс расширения StackExtensions и добавьте в него метод расширения Merge, который на вход принимает стек s1, и стек s2.
* Все элементы из s2 должны добавится в s1 в обратном порядке
* Сам метод должен быть доступен в класс Stack

### Доп. задание 2
* В класс Stack и добавьте статический метод Concat, который на вход неограниченное количество параметров типа Stack
* и возвращает новый стек с элементами каждого стека в порядке параметров, но сами элементы записаны в обратном порядке
 
 
