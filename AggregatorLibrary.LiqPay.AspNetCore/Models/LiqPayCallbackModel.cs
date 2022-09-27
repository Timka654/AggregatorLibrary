namespace AggregatorLibrary.LiqPay.AspNetCore.Models
{
    public class LiqPayCallbackModel
    {
        /// <summary>
        /// ID эквайера
        /// </summary>
        public double acq_id { get; set; }

        /// <summary>
        /// Тип операции. Возможные значения: pay - платеж, hold - блокировка средств на счету отправителя, paysplit - расщепление платежа, subscribe - создание регулярного платежа, paydonate - пожертвование, auth - предавторизация карты, regular - регулярный платеж
        /// </summary>
        public string action { get; set; }

        /// <summary>
        /// Комиссия агента в валюте платежа
        /// </summary>
        public double agent_commission { get; set; }

        /// <summary>
        /// Сумма платежа
        /// </summary>
        public double amount { get; set; }

        /// <summary>
        /// Бонус отправителя в валюте платежа debit
        /// </summary>
        public double amount_bonus { get; set; }

        /// <summary>
        /// Сумма транзакции credit в валюте currency_credit
        /// </summary>
        public double amount_credit { get; set; }

        /// <summary>
        /// Сумма транзакции debit в валюте currency_debit
        /// </summary>
        public double amount_debit { get; set; }

        /// <summary>
        /// Код авторизации по транзакции credit
        /// </summary>
        public string authcode_credit { get; set; }

        /// <summary>
        /// Код авторизации по транзакции debit
        /// </summary>
        public string authcode_debit { get; set; }

        /// <summary>
        /// Token карты оправителя
        /// </summary>
        public string card_token { get; set; }

        /// <summary>
        /// Комиссия с получателя в валюте currency_credit
        /// </summary>
        public double commission_credit { get; set; }

        /// <summary>
        /// Комиссия с отправителя в валюте currency_debit
        /// </summary>
        public double commission_debit { get; set; }

        /// <summary>
        /// Дата списания средств
        /// </summary>
        public string completion_date { get; set; }

        /// <summary>
        /// Дата создания платежа
        /// </summary>
        public string create_date { get; set; }

        /// <summary>
        /// Валюта платежа
        /// </summary>
        public string currency { get; set; }

        /// <summary>
        /// Валюта транзакции credit
        /// </summary>
        public string currency_credit { get; set; }

        /// <summary>
        /// Валюта транзакции debit
        /// </summary>
        public string currency_debit { get; set; }

        /// <summary>
        /// Уникальный идентификатор пользователя на сайте мерчанта. Максимальная длина 100 символов
        /// </summary>
        public string customer { get; set; }

        /// <summary>
        /// Комментарий к платежу
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Дата завершения/изменения платежа
        /// </summary>
        public string end_date { get; set; }

        /// <summary>
        /// Код ошибки
        /// </summary>
        public string err_code { get; set; }

        /// <summary>
        /// Описание ошибки
        /// </summary>
        public string err_description { get; set; }

        /// <summary>
        /// Дополнительная информация о платеже
        /// </summary>
        public string info { get; set; }

        /// <summary>
        /// IP адрес отправителя
        /// </summary>
        public string ip { get; set; }

        /// <summary>
        /// Возможные значения: 
        /// true - транзакция прошла с 3DS проверкой,
        /// false - транзакция прошла без 3DS проверки
        /// </summary>
        public bool is_3ds { get; set; }

        /// <summary>
        /// Order_id платежа в системе LiqPay
        /// </summary>
        public string liqpay_order_id { get; set; }

        /// <summary>
        /// Возможные значения: 5 - транзакция прошла с 3DS (эмитент и эквайер поддерживают технологию 3D-Secure), 6 - эмитент карты плательщика не поддерживает технологию 3D-Secure, 7 - операция прошла без 3D-Secure
        /// </summary>
        public double mpi_eci { get; set; }

        /// <summary>
        /// Order_id платежа
        /// </summary>
        public string order_id { get; set; }

        /// <summary>
        /// Id платежа в системе LiqPay
        /// </summary>
        public double payment_id { get; set; }

        /// <summary>
        /// Способ оплаты. Возможные значения card - оплата картой, liqpay - через кабинет liqpay, privat24 - через кабинет приват24, masterpass - через кабинет masterpass, moment_part - рассрочка, cash - наличными, invoice - счет на e-mail, qr - сканирование qr-кода
        /// </summary>
        public string paytype { get; set; }

        /// <summary>
        /// Публичный ключ магазина
        /// </summary>
        public string public_key { get; set; }

        /// <summary>
        /// Комиссия с получателя в валюте платежа
        /// </summary>
        public double receiver_commission { get; set; }

        /// <summary>
        /// Ссылка на которую необходимо перенаправить клиента для прохождения 3DS верификации
        /// </summary>
        public string redirect_to { get; set; }

        /// <summary>
        /// Дата последнего возврата по платежу
        /// </summary>
        public string refund_date_last { get; set; }

        /// <summary>
        /// Уникальный номер транзакции в системе авторизации и расчетов обслуживающего банка Retrieval Reference number
        /// </summary>
        public string rrn_credit { get; set; }

        /// <summary>
        /// Уникальный номер транзакции в системе авторизации и расчетов обслуживающего банка Retrieval Reference number
        /// </summary>
        public string rrn_debit { get; set; }

        /// <summary>
        /// Бонус отправителя в валюте платежа
        /// </summary>
        public double sender_bonus { get; set; }

        /// <summary>
        /// Банк отправителя
        /// </summary>
        public string sender_card_bank { get; set; }

        /// <summary>
        /// Страна карты отправителя. Цифровой ISO 3166-1 код
        /// </summary>
        public string sender_card_country { get; set; }

        /// <summary>
        /// Карта отправителя
        /// </summary>
        public string sender_card_mask2 { get; set; }

        /// <summary>
        /// Тип карты отправителя MC/Visa
        /// </summary>
        public string sender_card_type { get; set; }

        /// <summary>
        /// Комиссия с отправителя в валюте платежа
        /// </summary>
        public double sender_commission { get; set; }

        /// <summary>
        /// Имя отправителя
        /// </summary>
        public string sender_first_name { get; set; }

        /// <summary>
        /// Фамилия отправителя
        /// </summary>
        public string sender_last_name { get; set; }

        /// <summary>
        /// Телефон отправителя
        /// </summary>
        public string sender_phone { get; set; }

        /// <summary>
        /// Статус платежа. 
        /// Возможные значения:
        /// Конечные статусы платежа
        /// error Неуспешный платеж.Некорректно заполнены данные
        /// failure Неуспешный платеж
        /// reversed Платеж возвращен
        /// subscribed Подписка успешно оформлена
        /// success Успешный платеж
        /// unsubscribed Подписка успешно деактивирована
        /// Cтатусы требующие подтверждения платежа
        /// 3ds_verify Требуется 3DS верификация. 
        /// Для завершения платежа, требуется выполнить 3ds_verify
        /// captcha_verify Ожидается подтверждение captcha
        /// cvv_verify Требуется ввод CVV карты отправителя.
        /// Для завершения платежа, требуется выполнить cvv_verify
        /// ivr_verify Ожидается подтверждение звонком ivr
        /// otp_verify Требуется OTP подтверждение клиента.OTP пароль отправлен на номер телефона Клиента.
        /// Для завершения платежа, требуется выполнить otp_verify
        /// password_verify Ожидается подтверждение пароля приложения Приват24
        /// phone_verify Ожидается ввод телефона клиентом. 
        /// Для завершения платежа, требуется выполнить phone_verify
        /// pin_verify Ожидается подтверждение pin-code
        /// receiver_verify Требуется ввод данных получателя.
        /// Для завершения платежа, требуется выполнить receiver_verify
        /// sender_verify Требуется ввод данных отправителя.
        /// Для завершения платежа, требуется выполнить sender_verify
        /// senderapp_verify Ожидается подтверждение в приложении SENDER
        /// wait_qr Ожидается сканирование QR-кода клиентом
        /// wait_sender Ожидается подтверждение оплаты клиентом в приложении Privat24/SENDER
        /// Другие статусы платежа
        /// cash_wait Ожидается оплата наличными в ТСО
        /// hold_wait Сумма успешно заблокирована на счету отправителя
        /// invoice_wait Инвойс создан успешно, ожидается оплата
        /// prepared Платеж создан, ожидается его завершение отправителем
        /// processing Платеж обрабатывается
        /// wait_accept Деньги с клиента списаны, но магазин еще не прошел проверку. Если магазин не пройдет активацию в течение 180 дней, платежи будут автоматически отменены
        /// wait_card Не установлен способ возмещения у получателя
        /// wait_compensation Платеж успешный, будет зачислен в ежесуточной проводке
        /// wait_lc Аккредитив.Деньги с клиента списаны, ожидается подтверждение доставки товара
        /// wait_reserve Средства по платежу зарезервированы для проведения возврата по ранее поданной заявке
        /// wait_secure Платеж на проверке
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// Token платежа
        /// </summary>
        public string token { get; set; }

        /// <summary>
        /// Тип платежа
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Версия API. Текущее значение - 3
        /// </summary>
        public double version { get; set; }

        /// <summary>
        /// Код ошибки
        /// </summary>
        public string err_erc { get; set; }

        /// <summary>
        /// Категория товара
        /// </summary>
        public string product_category { get; set; }

        /// <summary>
        /// Описание товара
        /// </summary>
        public string product_description { get; set; }

        /// <summary>
        /// Название товара
        /// </summary>
        public string product_name { get; set; }

        /// <summary>
        /// Адрес страницы с товаром
        /// </summary>
        public string product_url { get; set; }

        /// <summary>
        /// Сумма возврата
        /// </summary>
        public double refund_amount { get; set; }

        /// <summary>
        /// Код верификации
        /// </summary>
        public string verifycode { get; set; }
    }
}
