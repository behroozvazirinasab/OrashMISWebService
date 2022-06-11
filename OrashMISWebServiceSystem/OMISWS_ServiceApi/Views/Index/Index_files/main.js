let contactItems = document.querySelectorAll(".item-contact-us");
let contentModalAbout = document.querySelectorAll(".content-modal");
console.log(contactItems);
contactItems.forEach((item) => {
  item.addEventListener("click", () => {
    if (item.classList.contains("item-address")) {
      contentModalAbout.forEach((itemModal) => {
        itemModal.classList.add("d-none");
      });
      document.querySelector(".about-address").classList.remove("d-none");
    } else if (item.classList.contains("item-phone")) {
      contentModalAbout.forEach((itemModal) => {
        itemModal.classList.add("d-none");
      });
      document.querySelector(".about-phone").classList.remove("d-none");
    } else if (item.classList.contains("item-time")) {
      contentModalAbout.forEach((itemModal) => {
        itemModal.classList.add("d-none");
      });
      document.querySelector(".about-time").classList.remove("d-none");
    } else if (item.classList.contains("item-email")) {
      contentModalAbout.forEach((itemModal) => {
        itemModal.classList.add("d-none");
      });
      document.querySelector(".about-email").classList.remove("d-none");
    }
  });
});
