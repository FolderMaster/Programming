namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Статус заказа.
    /// </summary>
    public enum OrderStatus
    {
        None,
        New,
        Processing,
        Assembly,
        Sent,
        Delivered,
        Returned,
        Abandoned
    }
}