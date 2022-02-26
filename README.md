# 1. Цель проекта

Цель проекта - разработать систему бронирования устройств для разработчиков. Разработчик может бронировать какие-либо устройства на определенный промежуток времени, отменять бронь. Также предусматривается возможность выставлять свои устройства.

# 2. Описание системы

Функциональность определена следующая:

1. Регистрация, авторизация
2. Страница со списком устройств
3. Страница с описанием устройства
4. Форма бронирования
5. Формы выставления своих устройств
6. Страница забронированных пользователем устройств

# 3. Функциональность
- 2.1. Регистрация

⋅⋅⋅Пользователю при регистрации нужно заполнить поля с почтой и паролем, а также имя, фамилию и должность(например, тестировщик).

- 2.2. Список устройств

⋅⋅⋅Основная страница системы, имеющая список всех доступных и недоступных устройств. С нее можно перейти в нужное устройство и посмотреть описание.

- 2.3. Описание устройств

⋅⋅⋅В странице с описанием устройств будет отображаться название, год выпуска, краткое описание. Также будут указаны дни и время в которое устройство занято

- 2.4. Бронирование

⋅⋅⋅Из описания устройства можно перейти в бронирование устройства. В брони нужно указать день и время пользования.

- 2.5. Выставление устройства

⋅⋅⋅На странице со списком устройств можно выставить своё устройство для других разработчиков. Перед этим заполняются следующие поля: название, год выпуска и краткое описание.

- 2.6. Забронированные устройства

⋅⋅⋅На странице с забронированными устройствами будет показан календарь, который показывает какое устройство когда занято, есть возможность преждевременно снять бронь.

# 4. Предполагаемый стек технологий

* Фронтенд: 
  - Angular
  - Typescript
* Бэкенд:
  ⋅⋅⋅ Для бэка будет написана простейшая "заглушка" для тестирования клиентской части

