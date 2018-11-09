feather.replace();
var chk_count = 0;
var items = [];

$(function() {
  $("#btn_del").click(function() {
    console.log("lenght: " + items.length);
    $.each(items, function(index, value) {
      // if (index > 0) {
      console.log(value);
      //}
    });
  });

  $("#chk_all").change(function() {
    if (this.checked) {
      $(".chk").each(function() {
        $(this).prop("checked", true);
        addItem($(this).attr("data-value"));
      });
    } else {
      $(".chk").each(function() {
        $(this).prop("checked", false);
        items = [];
      });
    }
  });
  $(".chk").change(function() {
    if (this.checked) {
      addItem($(this).attr("data-value"));
    } else {
      removItem($(this).attr("data-value"));
    }
  });
  $(".nav-link").click(function() {
    $(this).addClass("active");
    alert("oo");
  });
});
function removItem(i) {
  items.splice($.inArray(i, items), 1);
}
function addItem(i) {
  if ($.inArray(i, items) < 0) {
    items.push(i);
  }
}
