``Решение данной задачи следующее:``

1. Создаем функции **GetInput** для ввода размера и **GetInputText** для ввода строк массива. В первой используется целочисленный тип, во второй - текст. Размер будет аргументом, а ввод строк - в цикле создания массива.

2. Пишем **CreateArray** и **СonvertArray** для создания и вывода массива, используя цикл **for**. Обратите внимание на форматирование текста.

3. Создаем новый массив с другим аргументом (исходным массивом). Подходит только строка из 3 и менее символов. Элементы, удовлетворяющие условию, копируются. Используем **k** для счетчика в цикле **for** второго массива и **Array.Resize(ref newArray, k)** для уменьшения размера массива.

4. Выводим новый массив, также используя функцию для первого массива.