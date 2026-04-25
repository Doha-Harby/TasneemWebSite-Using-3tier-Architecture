// Sidebar toggle functionality
const sidebar = document.getElementById('sidebar');
const mainContent = document.getElementById('mainContent');
const toggleBtn = document.getElementById('toggleSidebar');
const mobileToggle = document.getElementById('mobileToggle');

// Check localStorage for sidebar state
const sidebarCollapsed = localStorage.getItem('sidebarCollapsed') === 'true';
if (sidebarCollapsed) {
    sidebar.classList.add('collapsed');
    mainContent.classList.add('expanded');
}

// Desktop toggle
if (toggleBtn) {
    toggleBtn.addEventListener('click', function () {
        sidebar.classList.toggle('collapsed');
        mainContent.classList.toggle('expanded');
        localStorage.setItem('sidebarCollapsed', sidebar.classList.contains('collapsed'));
    });
}

// Mobile toggle
if (mobileToggle) {
    mobileToggle.addEventListener('click', function () {
        sidebar.classList.toggle('show');
    });
}

// Close sidebar when clicking outside on mobile
document.addEventListener('click', function (event) {
    const isMobile = window.innerWidth <= 768;
    if (isMobile && sidebar.classList.contains('show')) {
        if (!sidebar.contains(event.target) && !mobileToggle.contains(event.target)) {
            sidebar.classList.remove('show');
        }
    }
});

// Handle window resize
let resizeTimer;
window.addEventListener('resize', function () {
    clearTimeout(resizeTimer);
    resizeTimer = setTimeout(function () {
        if (window.innerWidth > 768) {
            sidebar.classList.remove('show');
        }
    }, 250);
});

// Active link highlighting
function setActiveLink() {
    const currentUrl = window.location.pathname;
    const navLinks = document.querySelectorAll('.nav-link');

    // إزالة الـ active من جميع الروابط أولاً
    navLinks.forEach(link => {
        link.classList.remove('active');
    });

    // ثم إضافة الـ active للرابط المناسب فقط
    navLinks.forEach(link => {
        const linkUrl = link.getAttribute('href');

        if (linkUrl && currentUrl === linkUrl) {
            link.classList.add('active');
        } else if (linkUrl === '/' && currentUrl === '/') {
            link.classList.add('active');
        }
    });
}
setActiveLink();

// Notification click handler
document.querySelector('.notification-icon')?.addEventListener('click', function () {
    alert('لديك 3 إشعارات غير مقروءة');
});

// User avatar click handler
document.querySelector('.user-avatar')?.addEventListener('click', function () {
    alert('قائمة المستخدم - الملف الشخصي، الإعدادات، تسجيل الخروج');
});