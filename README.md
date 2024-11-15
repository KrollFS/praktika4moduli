Выполнил: "Филиппов Александр"
Группа: "МпК-361"
Задача: Разработать приложение с функционалом входа в систему и регистрации нового пользователя. Приложение должно включать два окна: окно авторизации и окно регистрации. После успешной регистрации пользователь попадает в личный кабинет, который реализован в зависимости от варианта задания. Работа с Git обязательна для управления версиями проекта.
Вход в систему – окно авторизация.

Поля ввода для E-mail и Пароль.

Кнопка "Вход".

Кнопка "Регистрация".

Добавить кнопку – Регистрация.

Окно Регистрация

Поля ввода для Фамилия

Поля ввода для Имя

Поля ввода для Отчество

Поля ввода для Дата рождения

Поля ввода для E-mail

Поля ввода для Пароль

Поля ввода для Повтор пароль

Кнопка регистрации

 Если нажали на кнопку и пароль совпал, появляется messegbox в нем сообщение: «Имя» вы зарегистрировались, и открывается окно Личного кабинета. Надпись в личном кабинете: Добро пожаловать, «ФИО». У каждого Варианта свой Личный Кабинет.

Если нажали на кнопку и пароль не совпал, messegbox в нем сообщение: Неверный пароль.

Работа с Git.


Варианты самостоятельной работы

Реализуйте личный кабинет пользователя.

В каждом кабинете должна быть реализована надпись: "Добро пожаловать, «ФИО»."

Должен быть реализован список по варианту. Элементы в XAML написаны в функционале, данные списка должны храниться в List с типом данных вашего класса. В каждом варианте указано, как должен выглядеть класс и как называется List.
Вариант 6 Список проектов

Пользователь добавляет проекты с указанием их статуса (в процессе, завершён) и может обновлять статус.

Функционал:

Поля для ввода названия проекта и статуса.

Кнопка добавления проекта.

ListBox для отображения списка проектов.

Кнопка удаления проекта.

Класс:

public class Project {

    public string Name { get; set; }

    public string Status { get; set; }

}