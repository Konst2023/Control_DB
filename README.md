# Алгоритм поиска элементов массива, удовлетворяющих условию задачи.

1. Создаем тестовый строковый массив. Используем для данных пример №1. 

2. Выводим начальный массив в терминал для контроля работы программы.

3. Создаем функцию преобразования входного строкового массива в выходной с условием отбора, указанным в задаче.

   - Находим размер выходного массива. Для этого пробегаемся в цикле по всем значениям входного массива и счетчиком считаем кол-во элементов, удовлетворяющих условию: длина строки меньше или равна трем.

   - Создаем пустой строковый массив длины, заданной счетчиком из предыдущего шага.

   - Заполняем выходной массив. Для этого пробегаемся в цикле по элементам входного массива и, если выполняется условие: длина строки меньше или равна трем, то во вложенном цикле, где мы пробегаемся по индексам выходного массива, мы проверяем, есть ли данные в ячейке массива, и когда ячейка пуста, то вставляем данные из входного массива.

4. Выводим получившийся массив в терминал.

     