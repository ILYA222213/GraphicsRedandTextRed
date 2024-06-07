# Приложение "Комбинированный редактор текста и графики"
С помощью этого программного обеспечения можно упростить редактирование текстов, а также изображений.

# Содержание
- [Технология](#технология)
- [Использование](#использование)
- [Тестирование](#тестирование)
- [Обратная связь](#обратная_связь)
- [Команда проекта](#команда_проекта)
- [Источники](#источники)

## Технологии
- VisualStudio 2022
- C#
- .NET 6.0

## Использование
Для работы с приложение необходимо следующее программное обеспечение:
Microsoft Visual Studio Community 2022

Перед началом работы с программным продуктом "Текстовый редактор с графическим редактором" на рабочем месте пользователя необходимо выполнить следующие действия:
1. Открыть программу Microsoft Visual Studio Community 2022.
2. Найти программу «Redactor.sin».
3. Открыть её.
4. Нажать на кнопку запуска

После открывается форма с несколькими доступными функциями
![image](https://github.com/ILYA222213/GraphicsRedandTextRed/assets/117897751/3a4a89b7-675b-4a61-aa0d-4607f02c9795)

В выпадающем списке есть несколько функций, такие как, "Открыть", "Сохранить". Эти функции предназначены для отрытия текстового файла, и сохранения его.
![image](https://github.com/ILYA222213/GraphicsRedandTextRed/assets/117897751/a4128be4-10bd-4cce-9ab5-94a52c5861a6)

Щелкнув по кнопке "Открыть" откроется диалоговое окно, где вы сможете выбрать нужный вам файл.
![image](https://github.com/ILYA222213/GraphicsRedandTextRed/assets/117897751/52ad842a-8631-4e39-ba6d-fac0175889e4)

Щелкнув по кнопке "Сохранить", вы сможете сохранить измененный вами файл.
![image](https://github.com/ILYA222213/GraphicsRedandTextRed/assets/117897751/9eb9e601-c7f5-4524-b5a1-bc5580700bdd)

В выбадающем списке "Парвка" присутствуют такие функции как, "Копировать", "Вставить", "Вырезать", "Выделить всё"

![image](https://github.com/ILYA222213/GraphicsRedandTextRed/assets/117897751/c4bf2751-b237-4824-aceb-2677c851c542)

Следующая функция это изменение шрифта, благодаря этой функции можно измениеть размер, сам шрифт, назначение, видоизменене, набор символов.
![image](https://github.com/ILYA222213/GraphicsRedandTextRed/assets/117897751/50b75515-3a4e-4a28-ad17-d18b38ef3a05)

Также с момощью кнопки "Фон" вы можете изменить цвет фона рабочего окна.
![image](https://github.com/ILYA222213/GraphicsRedandTextRed/assets/117897751/f45f7d57-008b-448f-b1a8-2173489f56f5)

Функция "Сохранить как QR" даёт вам возможность сохранить данные вашего файла QR- кодом, и скохранить этот QR на компьютер

![image](https://github.com/ILYA222213/GraphicsRedandTextRed/assets/117897751/3877a97e-f3e5-446d-b686-209c6bcb70ca)

С помощью кнопки "Рисовать", вы можете перейти на форму для графического редактиррования, тут вы сможете:
1. Открыть изображение
2. Выбрать цвет линии
3. Изменить размер линии
4. Сохранить изображение
5. Посмотреть информацию о программе
6. Добавить фигуры
7. Очистить рабочее место с помощью сторки или же одним нажатием стереть все
8. Выйти из формы

![image](https://github.com/ILYA222213/GraphicsRedandTextRed/assets/117897751/e4c5c061-3ebe-4556-9132-c15ddd283ed5)

![image](https://github.com/ILYA222213/GraphicsRedandTextRed/assets/117897751/297c8161-5869-4109-a93a-252e09e6b50b)

![image](https://github.com/ILYA222213/GraphicsRedandTextRed/assets/117897751/e55a4e70-3145-40fa-8320-d9351e5300e9)

![image](https://github.com/ILYA222213/GraphicsRedandTextRed/assets/117897751/77c19a52-3c73-4bdf-b739-324914ffabe4)

![image](https://github.com/ILYA222213/GraphicsRedandTextRed/assets/117897751/d9597246-85e6-40a8-b9a1-3fcb695ba0a3)

## Тестирование
# Тестовый граф
***
![image](https://github.com/ILYA222213/GraphicsRedandTextRed/assets/117897751/85745cef-17f7-4c05-9fb4-24f9b74c7535)


На рисунке 1 представлен граф программы

Рисунок 1 – Граф программы

1. Открытие программы
2. Открытие файла 
3. Открытие формы "Графический редактор"
4. Редактирование файла
5. Создание QR кода
6. Выбор изображения
7. Сохранение файла с QR кодом
8. Изменение изображения
9. Сохранение изображения
10. Выход из формы
11. Выход из программы

# Тестовые пути
***
Т1: 1-2-4-7-12

Т2: 1-2-4-5-7-12

Т3: 1-3-6-8-10-11-12

Путь 1: Открытие окна редактирование, открытие файла, редактирование, сохранение файла, выход из приложения;

Путь 2: Открытие окна редактирование, открытие файла, редактирование, создание QR- кода, сохранение файла с QR-кодом, выход из приложения;

Путь 3: Открытие окна редактирования, открытие формы "Графический редактор", выбор изображения, изменение изображения, сохранение изображения, выход из формы, выход из приложения

![image](https://github.com/ILYA222213/GraphicsRedandTextRed/assets/117897751/be8f512d-57be-4d37-86b1-70a810932006)
![image](https://github.com/ILYA222213/GraphicsRedandTextRed/assets/117897751/46f09bfa-2102-4c74-8314-11c779e055a1)
![image](https://github.com/ILYA222213/GraphicsRedandTextRed/assets/117897751/d629a5ec-d78a-42b8-8f6e-cf1d46882dfd)

## Обратная связь
По вопросам, возникшим при эксплуатации программного продукта обращайтесть на мою электронную почту: il.ruzanovil@yandex.ru

## Команда проекта
Рузанов Илья - Главный разработчик, программист, тестироващик, дизайнер, гений, миллиардер, плей-бой, филантроп

## Источники
http://metanit.com/sharp/

https://metanit.com/sharp/windowsforms/

## Видео гайд
[Клик](https://www.youtube.com/watch?v=dQw4w9WgXcQ)


